using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChooseEditorWindow : EditorWindow
{
    [MenuItem("Menu/ChooseEditorWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<ChooseEditorWindow>().Show();
    }

    public int index1;
    public int index2;
    public EnumDemo mEnumDemo;
    public void OnGUI()
    {
        string[] strs = new string[] { "Ò»ºÅ´®", "2ºÅ´®", "troisºÅ´®", "fourºÅ´®", "VºÅ´®" };
        int[] ints = new int[] { 123, 233, 366, 456, 514 };

        this.index1 = EditorGUILayout.Popup(this.index1, strs);//Ñ¡Ôñ1
        this.index2 = EditorGUILayout.IntPopup(this.index2, strs, ints);//Ñ¡Ôñ2

        this.mEnumDemo = (EnumDemo)EditorGUILayout.EnumPopup(this.mEnumDemo);//Ã¶¾Ù
    }

    public enum EnumDemo
    {
        mString,mInt,mFloat,mDouble,mColor
    }

}
