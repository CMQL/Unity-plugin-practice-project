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
        EditorGUILayout.LabelField("�����������");
        this.mInt = EditorGUILayout.IntField(this.mInt);

        EditorGUILayout.LabelField("�����������");
        this.mFloat = EditorGUILayout.FloatField(this.mFloat);

    }
}
