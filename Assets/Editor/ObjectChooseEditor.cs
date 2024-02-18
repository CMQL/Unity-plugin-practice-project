using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ObjectChooseEditor : EditorWindow
{
    [MenuItem("Menu/ObjectChooseEditor")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<ObjectChooseEditor>().Show();
    }

    public string mTag;
    public int mLayer;
    public Object mObject;

    public void OnGUI()
    {
        this.mTag = EditorGUILayout.TagField("Tag");
        EditorGUILayout.Space();

        this.mLayer = EditorGUILayout.LayerField(this.mLayer);
        EditorGUILayout.Space();

        this.mObject = EditorGUILayout.ObjectField("Ñ¡ÔñÒ»ÏÂ", this.mObject, typeof(Camera), true);
    }
}
