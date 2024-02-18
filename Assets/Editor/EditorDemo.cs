using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Test1))]
public class EditorDemo : Editor
{
    public SerializedObject mObj;

    public SerializedProperty mIntVal;
    public SerializedProperty mFloatVal;
    public SerializedProperty mStrVal;
    public SerializedProperty mTypeDemo;

    private void OnEnable()
    {
        this.mObj = new SerializedObject(target);
        this.mIntVal = this.mObj.FindProperty("mIntVal");
        this.mFloatVal = this.mObj.FindProperty("mFloatVal");
        this.mStrVal = this.mObj.FindProperty("mStrVal");

        this.mTypeDemo = this.mObj.FindProperty("mTypeDemo");
    }

    public override void OnInspectorGUI()
    {
        this.mObj.Update();

        EditorGUILayout.PropertyField(this.mIntVal);
        EditorGUILayout.PropertyField(this.mFloatVal);
        EditorGUILayout.PropertyField(this.mStrVal);

        EditorGUILayout.PropertyField(this.mTypeDemo,true);

        this.mObj.ApplyModifiedProperties();
    }

}
