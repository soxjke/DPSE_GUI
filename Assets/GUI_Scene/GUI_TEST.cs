using UnityEngine;
using System.Collections;

public class GUI_TEST : MonoBehaviour {
	
	private string textFieldString = "";
	
	void OnGUI()
	{
		float width = Screen.width;
		float height = Screen.height;
		GUI.Box(new Rect(2 * width / 3, 0, width / 3, height), "Properties");
		textFieldString = GUI.TextField(new Rect(2 * width / 3, 10, width / 3 + 10, 30), textFieldString);
	}
	
	void Start() 
	{
		TouchScreenKeyboard.hideInput = true;
	}
}
