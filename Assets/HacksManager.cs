using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uAdventure.Core;
using uAdventure.Runner;
using uAdventure.Geo;

public class HacksManager : MonoBehaviour {

    public void ActivarModoManual()
    {
        GeoExtension.Instance.SwitchDebugLocation();
    }

    public void IrARecogida()
    {
        GUIManager.Instance.ShowConfigMenu();
        Game.Instance.Execute(new EffectHolder(new Effects()
        {
            new TriggerSceneEffect("Plaza", 0, 0),
            new ActivateEffect("Intro"),
            new ActivateEffect("Alive"),
            new ActivateEffect("Normal"),
            new ActivateEffect("Bolsi"),
            new ActivateEffect("Recogida")
        }));
    }

    public void IrAFarmacia()
    {
        GUIManager.Instance.ShowConfigMenu();
        Game.Instance.Execute(new EffectHolder(new Effects()
        {
            new TriggerSceneEffect("FacultadFarmacia", 0, 0),
            new ActivateEffect("Intro"),
            new ActivateEffect("Alive"),
            new ActivateEffect("Normal"),
            new ActivateEffect("Bolsi"),
            new ActivateEffect("Recogida")
        }));
    }

    public void IrAMedicina()
    {
        GUIManager.Instance.ShowConfigMenu();
        Game.Instance.Execute(new EffectHolder(new Effects()
        {
            new TriggerSceneEffect("FacultadMedicina", 0, 0),
            new ActivateEffect("Intro"),
            new ActivateEffect("Alive"),
            new ActivateEffect("Normal"),
            new ActivateEffect("Bolsi"),
            new ActivateEffect("Recogida")
        }));
    }

    public void IrAlFinal()
    {
        GUIManager.Instance.ShowConfigMenu();
        Game.Instance.Execute(new EffectHolder(new Effects()
        {
            new TriggerSceneEffect("Ending", 0, 0),
            new ActivateEffect("Intro"),
            new ActivateEffect("Alive"),
            new ActivateEffect("Normal"),
            new ActivateEffect("Bolsi"),
            new ActivateEffect("Recogida"),
            new TriggerConversationEffect("BatallaFinal")
        }));
    }
}
