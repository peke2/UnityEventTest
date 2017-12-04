using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SceneGUI))]
public class ScenGUIEditor : Editor {
	void OnSceneGUI()
	{
		Debug.Log("called["+target.name+"] = "+ Event.current.type.ToString());
	}
}
