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

    public string mText = "看我看我";
    public Color mColor = Color.white;
    public void OnGUI()
    {
        this.mText = EditorGUILayout.TextField(this.mText);//单行
        this.mText = EditorGUILayout.TextArea(this.mText);//多行
        this.mText = EditorGUILayout.PasswordField(this.mText);//密码
        this.mColor = EditorGUILayout.ColorField(this.mColor);//颜色
    }
}
