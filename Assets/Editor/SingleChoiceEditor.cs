using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SingleChoiceEditor : EditorWindow
{
    [MenuItem("Menu/SingleChoiceEditor")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<SingleChoiceEditor>().Show();
    }

    public bool mBool;
    public bool mFoldout;

    public void OnGUI()
    {
        EditorGUILayout.LabelField("µÚÒ»Ïî");
        EditorGUILayout.Space();

        //this.mBool = EditorGUILayout.Toggle(this.mBool);
        this.mBool = EditorGUILayout.Toggle("Yes or no",this.mBool);

        this.mFoldout = EditorGUILayout.Foldout(this.mFoldout, "ÕÛµþ");
        Debug.Log(this.mFoldout);

        if(this.mFoldout)
        {
            EditorGUILayout.LabelField("A");
            EditorGUILayout.LabelField("B");
            EditorGUILayout.LabelField("C");
        }
    }
}
