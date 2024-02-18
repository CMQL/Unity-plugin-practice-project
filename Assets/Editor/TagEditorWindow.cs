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

    public string mText = "贴标签！";
    public void OnGUI()
    {
        EditorGUILayout.PrefixLabel(this.mText);//单独无效
        EditorGUILayout.Space();

        this.mText = EditorGUILayout.TagField(this.mText);//下拉
        EditorGUILayout.Space();

        EditorGUILayout.LabelField(this.mText);//不可选中（无法CP）
        EditorGUILayout.Space();

        EditorGUILayout.SelectableLabel(this.mText);//可选中（可CP）
        EditorGUILayout.Space();
    }
}
