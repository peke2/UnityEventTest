using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SceneGUI))]
public class ScenGUIEditor : Editor {

	//	コンパイル後などdelegateがクリアされた後に呼び出される
	//	メソッドは static であること
    [InitializeOnLoadMethod]
	static void init()
	{
		//	ヒエラルキーウィンドウ変更デリゲートは、選択の変更だけでは呼び出されないので注意
		Debug.Log("登録");
		EditorApplication.hierarchyWindowItemOnGUI += ChangedHierarchy;
	}

	static void ChangedHierarchy(int instanceID, Rect selectionRect)
	{
		//	ヒエラルキー上の数値、オブジェクトの変更時のみ呼び出される
		#if false
		[呼び出される操作]
			インスペクター上でのオブジェクトの座標変更
			ツリー上へのオブジェクト追加・削除
			シーンビューで変更した座標をアンドゥ
		[呼び出されない操作]
			シーンビュー上でのオブジェクトの座標変更
			ヒエラルキーのオブジェクト選択
		#endif
		//Debug.Log("ヒエラルキー変更");

	}


	//void initMethod()
    void OnEnable()
    {
        //OnEnable はオブジェクトが選択状態になった時にも呼び出される
        //Debug.Log("コールバック登録["+target.name+"]");

        Selection.selectionChanged += selectionChanged;
    }

    private void OnDisable()
    {
		//Debug.Log("コールバック解除["+target.name+"]");

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
