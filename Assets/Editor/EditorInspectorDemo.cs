using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Test2))]
public class EditorInspectorDemo : Editor
{
    public SerializedObject mObj;
    public SerializedProperty mEnumDemo;
    public SerializedProperty mInt;
    public SerializedProperty mBool;
    public SerializedProperty mFloat;
    public SerializedProperty mString;
    public SerializedProperty mColor;

    private void OnEnable()
    {
        this.mObj = new SerializedObject(target);
        this.mEnumDemo = this.mObj.FindProperty("mEnumDemo");
        this.mInt= this.mObj.FindProperty("mInt");
        this.mBool = this.mObj.FindProperty("mBool");
        this.mFloat = this.mObj.FindProperty("mFloat");
        this.mString = this.mObj.FindProperty("mStr");
        this.mColor = this.mObj.FindProperty("mColor");
    }

    public override void OnInspectorGUI()
    {
        this.mObj.Update();
        EditorGUILayout.PropertyField(this.mEnumDemo);

        switch(this.mEnumDemo.enumValueIndex)
        {
            case 1:
                EditorGUILayout.PropertyField(this.mInt);
                break;
            case 2:
                EditorGUILayout.PropertyField(this.mBool);
                break;
            case 3:
                EditorGUILayout.PropertyField(this.mFloat);
                break;
            case 4:
                EditorGUILayout.PropertyField(this.mString);
                break;
            case 5:
                EditorGUILayout.PropertyField(this.mColor);
                break;
        }

        this.mObj.ApplyModifiedProperties();
    }

}


