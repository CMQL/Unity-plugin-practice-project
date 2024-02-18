using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TextEditorWindow:EditorWindow
{
    [MenuItem("Menu/TextEditorWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<TextEditorWindow>().Show();
    }

    public string mText = "���ҿ���";
    public Color mColor = Color.white;
    public void OnGUI()
    {
        this.mText = EditorGUILayout.TextField(this.mText);//����
        this.mText = EditorGUILayout.TextArea(this.mText);//����
        this.mText = EditorGUILayout.PasswordField(this.mText);//����
        this.mColor = EditorGUILayout.ColorField(this.mColor);//��ɫ
    }
}
