using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TagEditorWindow : EditorWindow
{
    [MenuItem("Menu/TagEditorWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<TagEditorWindow>().Show();
    }

    public string mText = "����ǩ��";
    public void OnGUI()
    {
        EditorGUILayout.PrefixLabel(this.mText);//������Ч
        EditorGUILayout.Space();

        this.mText = EditorGUILayout.TagField(this.mText);//����
        EditorGUILayout.Space();

        EditorGUILayout.LabelField(this.mText);//����ѡ�У��޷�CP��
        EditorGUILayout.Space();

        EditorGUILayout.SelectableLabel(this.mText);//��ѡ�У���CP��
        EditorGUILayout.Space();
    }
}
