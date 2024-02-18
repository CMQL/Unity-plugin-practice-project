using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorDemo2 : EditorWindow
{
    [MenuItem("Menu/NewWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<EditorDemo2>().Show();
    }

    public void OnGUI()
    {
        if(GUILayout.Button("关闭"))
        {
            this.Close();
        }
    }

    public int index = 0;
    //
    //自刷新
    //
    /*public void Update()
    {
        index1++;
        Debug.Log("次数" + index1);
    }*/

    /*public void OnInspectorUpdate()
    {
        index++;
        Debug.Log("记录次数：" + index);
    }*/
    //
    //
    //

    public void OnDestroy()
    {
        Debug.Log("我噶了");
    }
    public void OnSelectionChange()
    {
        //Debug.Log(Selection.objects[1]);
        for(int i=0;i<Selection.gameObjects.Length;i++)
        {
            Debug.Log("Hierarchy第" + i + "个，名字是" + Selection.gameObjects[i].name);
        }

        for(int j=0;j<Selection.objects.Length;j++)
        {
            Debug.Log("Project第" + j + "个，名字是" + Selection.objects[j].name);
        }

    }

    public void OnFocus()
    {
        Debug.Log("选到我辣");
    }
    public void OnLostFocus()
    {
        Debug.Log("不选我辣");
    }

    public void OnHierarchyChange()
    {
        Debug.Log("Hierarchy有变");
    }
    public void OnProjectChange()
    {
        Debug.Log("Project有变");
    }

}
