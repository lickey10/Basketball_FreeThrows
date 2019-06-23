﻿using UnityEngine;
using System.Collections;

public class Logo : MonoBehaviour {
	public GUIStyle customGuiStyle;
	public string GameName = "";
	public Color TextColor = Color.green;
	public Color ShadowColor = Color.black;

	// Use this for initialization
	void Start () {
		customGuiStyle = new GUIStyle();
		
		customGuiStyle.font = (Font)Resources.Load("Fonts/advlit");
		customGuiStyle.active.textColor = Color.red; // not working
		customGuiStyle.hover.textColor = Color.blue; // not working
		customGuiStyle.normal.textColor = Color.green;
		customGuiStyle.fontSize = 60;

		
		customGuiStyle.stretchWidth = true; // ---
		customGuiStyle.stretchHeight = true; // not working, since backgrounds aren't showing
		
		customGuiStyle.alignment = TextAnchor.MiddleCenter;
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		int logoX = (Screen.width - 500 ) / 2;
		int logoY = (Screen.height - 475) / 2;
		int buttonWidth = 120;
		int buttonHeight = 60;

		//logo
		//drop shadow
		customGuiStyle.normal.textColor = ShadowColor;
		GUI.Box(new Rect( logoX+3, logoY + gamestate.Instance.GetBannerHeight() + 3, 450, 30 ), GameName ,customGuiStyle);
		
		customGuiStyle.normal.textColor = TextColor;
		GUI.Box(new Rect( logoX, logoY + gamestate.Instance.GetBannerHeight(), 450, 30 ), GameName ,customGuiStyle);


	}
}
