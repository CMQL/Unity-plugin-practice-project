using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SliderEditorWindow : EditorWindow
{
    [MenuItem("Menu/SliderEditorWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<SliderEditorWindow>().Show();
    }

    public float mFloat;
    public int mInt;

    public float mMinVal;
    public float mMaxVal;

    public void OnGUI()
    {
        this.mFloat = EditorGUILayout.Slider(this.mFloat, 0, 100);//С����
        this.mInt = EditorGUILayout.IntSlider(this.mInt, 0, 100);//������

        EditorGUILayout.MinMaxSlider(ref mMinVal, ref mMaxVal, 0, 100);//��С�����
    }
}
