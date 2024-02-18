using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WindowDemo : EditorWindow
{
    [MenuItem("Menu/ShowWindow")]
    public static void ShowWindow()
    {
        //WindowDemo.CreateInstance<WindowDemo>().Show();
        //WindowDemo.CreateInstance<WindowDemo>().ShowUtility();
        WindowDemo.CreateInstance<WindowDemo>().ShowPopup();

    }

    public void OnGUI()
    {
        if(GUILayout.Button("¹Ø±Õ"))
        {
            this.Close();
        }
    }
}
