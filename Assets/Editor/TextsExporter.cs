using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using uAdventure.Core;
using uAdventure.Editor;
using System.Linq;
using uAdventure.Geo;

public class TextsExporter {

    [MenuItem("uAdventure/Export conversations")]
    public static void ExportConversations ()
    {
        if (!Controller.Instance.Initialized)
        {
            return;
        }

        var conversations = Controller.Instance.SelectedChapterDataControl.getConversationsList();
        var items = Controller.Instance.SelectedChapterDataControl.getItemsList();

        using (var outFile = System.IO.File.Open("conversations.txt", System.IO.FileMode.OpenOrCreate))
        using (var outWriter = new System.IO.StreamWriter(outFile))
        {
            foreach (var conversation in conversations.getConversations())
            {
                outWriter.WriteLine("Conversation: " + conversation.getId());
                var nodeNames = new Dictionary<ConversationNodeDataControl, string>();
                var nodeContinuations = new Dictionary<ConversationNodeDataControl, List<string>>();
                var number = 0;

                foreach(var node in conversation.getAllNodes())
                {
                    nodeNames.Add(node, "Node: " + (++number));
                    nodeContinuations.Add(node, new List<string>());
                }
                foreach (var node in conversation.getAllNodes())
                {
                    var childNumber = 0;
                    foreach (var child in node.getChilds())
                    {
                        var afterText = " -- Empty node -- ";
                        if(node.getChildCount() > 1)
                        {
                            afterText = node.getLine(childNumber).getText();
                        }
                        else if(node.getLineCount() > 0)
                        { 
                            afterText = node.getLine(node.getLineCount()-1).getText();
                        }

                        nodeContinuations[child].Add(" * After " + nodeNames[node] + ": " + afterText);
                        childNumber++;
                    }
                }

                foreach (var node in conversation.getAllNodes())
                {
                    outWriter.WriteLine(nodeNames[node]);
                    foreach(var continuation in nodeContinuations[node])
                    {
                        outWriter.WriteLine(continuation);
                    }

                    foreach(var line in node.getLines())
                    {
                        outWriter.WriteLine(" - " + line.getName() + ": " + line.getText()); 
                    }

                    WriteEffects(outWriter, node.getEffects());
                }
                outWriter.WriteLine("");

            }
            
            foreach (var item in items.getItems())
            {
                if(!item.getActionsList().getActions().Any(a => a.getType() == Controller.ACTION_GRAB || a.getType() == Controller.ACTION_USE))
                {
                    continue;
                }

                outWriter.WriteLine("Objeto: " + item.getId());

                foreach(var action in item.getActionsList().getActions().Where(a => a.getType() == Controller.ACTION_GRAB || a.getType() == Controller.ACTION_USE))
                {
                    switch (action.getType())
                    {
                        case Controller.ACTION_EXAMINE:
                            outWriter.WriteLine(" - Al examinarlo:");
                            break;
                        case Controller.ACTION_GRAB:
                            outWriter.WriteLine(" - Al cogerlo:");
                            break;
                        case Controller.ACTION_USE:
                            outWriter.WriteLine(" - Al tirarlo:");
                            break;
                    }
                    var effects = action.getEffects();
                    WriteEffects(outWriter, effects);
                }
            }
            foreach (var geoElement in GeoController.Instance.GeoElements.DataControls)
            {
                if (!geoElement.GeoActions.DataControls.Any(a => a.Effects.getEffects().Any(e => e is SpeakPlayerEffect || e is SpeakCharEffect)))
                {
                    continue;
                }

                outWriter.WriteLine("Lugar: " + (geoElement.getContent() as GeoElement).Id);

                foreach (var action in geoElement.GeoActions.DataControls)
                {
                    outWriter.WriteLine(" - " + action.getType() + ":");

                    foreach (var effect in action.Effects.getEffects().Where(e => e is SpeakCharEffect || e is SpeakPlayerEffect))
                    {
                        var abstractEffect = effect as AbstractEffect;
                        if (abstractEffect != null && abstractEffect.getConditions().Size() > 0)
                        {
                            outWriter.Write("  * Cuando " + abstractEffect.getConditions().ToString() + ": ");
                        }
                        else
                        {
                            outWriter.Write("  * ");
                        }

                        var speakCharEffect = effect as SpeakCharEffect;
                        var speakerName = "Player";
                        var text = "";

                        if (speakCharEffect != null)
                        {
                            speakerName = speakCharEffect.getTargetId();
                            text = speakCharEffect.getLine();
                        }
                        else
                        {
                            text = (effect as SpeakPlayerEffect).getLine();
                        }

                        outWriter.WriteLine(speakerName + ": " + text);
                    }
                }
            }
        }
    }

    private static void WriteEffects(System.IO.StreamWriter outWriter, EffectsController effects)
    {
        foreach (var effect in effects.getEffects().Where(e => e is SpeakCharEffect || e is SpeakPlayerEffect))
        {
            var abstractEffect = effect as AbstractEffect;
            if (abstractEffect != null && abstractEffect.getConditions().Size() > 0)
            {
                outWriter.Write("  * Cuando " + abstractEffect.getConditions().ToString() + ": ");
            }
            else
            {
                outWriter.Write("  * "); 
            }

            var speakCharEffect = effect as SpeakCharEffect;
            var speakerName = "Player";
            var text = "";

            if (speakCharEffect != null)
            {
                speakerName = speakCharEffect.getTargetId();
                text = speakCharEffect.getLine();
            }
            else
            {
                text = (effect as SpeakPlayerEffect).getLine();
            }

            outWriter.WriteLine(speakerName + ": " + text);
        }
    }
}
