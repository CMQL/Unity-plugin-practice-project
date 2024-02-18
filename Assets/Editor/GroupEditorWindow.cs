using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GroupEditorWindow : EditorWindow
{
    [MenuItem("Menu/GroupEditorWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<GroupEditorWindow>().Show();
    }

    public bool mBool;
    public Vector2 mVector;

    public void OnGUI()
    {
        //常规不需要
        EditorGUILayout.BeginScrollView(this.mVector);

        this.mBool = EditorGUILayout.BeginToggleGroup("选择分组", mBool);
        EditorGUILayout.LabelField("组Toggle 标签");
        EditorGUILayout.TextField("组Toggle 文本");
        EditorGUILayout.EndToggleGroup();
        EditorGUILayout.Space();

        Rect HorizonRect = EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("组Horizon 标签");
        EditorGUILayout.TextField("组Horizon 文本");
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Space();

        Rect VerticalRect = EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("组Vertical 标签");
        EditorGUILayout.TextField("组Vertical 标签");
        EditorGUILayout.EndVertical();
        EditorGUILayout.Space();

        EditorGUILayout.EndScrollView();
    }
}
