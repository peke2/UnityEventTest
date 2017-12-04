using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SceneGUI))]
public class ScenGUIEditor : Editor {

    //[InitializeOnLoadMethod]
    //void initMethod()
    void OnEnable()
    {
        //OnEnable はオブジェクトが選択状態になった時にも呼び出される
        Debug.Log("コールバック登録["+target.name+"]");

        Selection.selectionChanged += selectionChanged;
    }

    private void OnDisable()
    {
        Selection.selectionChanged -= selectionChanged;
    }

    void selectionChanged()
    {
        string name = Selection.activeGameObject.name;
        Debug.Log("選択変更=>"+name);
    }


    bool isFirst = true;
    void OnSceneGUI()
	{
    /*
        GameObject gobj = ((SceneGUI)target).gameObject;

        bool isSelected = false;

        if( isFirst == true )
        {
            Debug.Log("選択["+gobj.name+"]");
            isFirst = false;

            isSelected = true;
        }

        if( Event.current.type == EventType.Used )
        {
            isFirst = true;
        }

        if( isSelected == true )
        {
            isFirst = true;
            Selection.activeGameObject = gobj.transform.parent.gameObject;
        }
        */
		//Debug.Log("called["+target.name+"] = "+ Event.current.type.ToString());
	}
}
