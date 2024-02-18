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
        //���治��Ҫ
        EditorGUILayout.BeginScrollView(this.mVector);

        this.mBool = EditorGUILayout.BeginToggleGroup("ѡ�����", mBool);
        EditorGUILayout.LabelField("��Toggle ��ǩ");
        EditorGUILayout.TextField("��Toggle �ı�");
        EditorGUILayout.EndToggleGroup();
        EditorGUILayout.Space();

        Rect HorizonRect = EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("��Horizon ��ǩ");
        EditorGUILayout.TextField("��Horizon �ı�");
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Space();

        Rect VerticalRect = EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("��Vertical ��ǩ");
        EditorGUILayout.TextField("��Vertical ��ǩ");
        EditorGUILayout.EndVertical();
        EditorGUILayout.Space();

        EditorGUILayout.EndScrollView();
    }
}
