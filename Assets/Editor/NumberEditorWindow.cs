using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class NumberEditorWindow : EditorWindow
{
    [MenuItem("Menu/NumberEditorWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<NumberEditorWindow>().Show();
    }

    public int mInt;
    public float mFloat;

    public void OnGUI()
    {
        EditorGUILayout.LabelField("整数数据如此");
        this.mInt = EditorGUILayout.IntField(this.mInt);

        EditorGUILayout.LabelField("浮点数据如此");
        this.mFloat = EditorGUILayout.FloatField(this.mFloat);

    }
}
