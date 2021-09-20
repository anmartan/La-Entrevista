using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UVRectChanger : MonoBehaviour {

    public int rotation = 0;
    public bool useCustom = false;
    public Rect customUVRect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var uvRect = GetComponent<RawImage>().uvRect;
        switch (rotation)
        {
            case 0:
                //uvRect = new Rect(1, 0, -1, 1);
                uvRect = new Rect(0, 0, 1, 1);
                break;
            case 90:
                uvRect = new Rect(1, 0, -1, 1);
                break;
            case 180:
                uvRect = new Rect(1, 1, -1, -1);
                break;
            case 270:
                uvRect = new Rect(0, 1, 1, -1);
                break;
        }

        if (useCustom)
        {
            GetComponent<RawImage>().uvRect = customUVRect;
        }
        else
        {
            GetComponent<RawImage>().uvRect = uvRect;
        }
    }
}
