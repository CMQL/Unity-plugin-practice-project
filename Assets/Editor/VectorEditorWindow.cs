using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class VectorEditorWindow : EditorWindow
{
    [MenuItem("Menu/VectorEditorWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<VectorEditorWindow>().Show();
    }

    public Vector2 mPos2;
    public Vector3 mPos3;
    public Vector4 mPos4;
    public Rect mRect;
    public Bounds mBounds;
    public void OnGUI()
    {
        this.mPos2 = EditorGUILayout.Vector2Field("2D向量", this.mPos2);
        this.mPos3 = EditorGUILayout.Vector3Field("3D向量", this.mPos3);
        this.mPos4 = EditorGUILayout.Vector4Field("4D向量", this.mPos4);

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("矩阵形式");
        this.mRect = EditorGUILayout.RectField(this.mRect);
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("间距");
        this.mBounds = EditorGUILayout.BoundsField(this.mBounds);
    }

}
