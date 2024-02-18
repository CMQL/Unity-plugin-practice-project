using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class OtherEditorWindow : EditorWindow
{
    [MenuItem("Menu/OtherEditorWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<OtherEditorWindow>().Show();
    }

    public AnimationCurve mAC = new AnimationCurve();
    public Object mObj;
    public bool mSelect;

    public void OnGUI()
    {
        this.mAC = EditorGUILayout.CurveField("∂Øª≠", this.mAC);
        EditorGUILayout.Space();

        this.mObj = EditorGUILayout.ObjectField("Œ“ «À≠", this.mObj, typeof(Transform), true);
        if(this.mObj!=null)
        {
            this.mSelect = EditorGUILayout.InspectorTitlebar(this.mSelect, this.mObj);
        }


    }


}
