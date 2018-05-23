﻿using System.Collections;
using System.Collections.Generic;
using Torii;
using Torii.Resource;
using Torii.UI;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour {

    void Awake()
    {
        ToriiToolkit.Initialize();
    }

	void Start ()
	{
        GameObject canvas = GameObject.FindWithTag("MainCanvas");
	    GameObject tuiWidget = TUIWidget.Create(WidgetLayoutType.Vertical, WidgetBackgroundType.Sprite,
	        Application.streamingAssetsPath + "/ui/sprite/test-non9s.json");
        tuiWidget.transform.SetParent(canvas.transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
