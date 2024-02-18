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
        if(GUILayout.Button("�ر�"))
        {
            this.Close();
        }
    }

    public int index = 0;
    //
    //��ˢ��
    //
    /*public void Update()
    {
        index1++;
        Debug.Log("����" + index1);
    }*/

    /*public void OnInspectorUpdate()
    {
        index++;
        Debug.Log("��¼������" + index);
    }*/
    //
    //
    //

    public void OnDestroy()
    {
        Debug.Log("�Ҹ���");
    }
    public void OnSelectionChange()
    {
        //Debug.Log(Selection.objects[1]);
        for(int i=0;i<Selection.gameObjects.Length;i++)
        {
            Debug.Log("Hierarchy��" + i + "����������" + Selection.gameObjects[i].name);
        }

        for(int j=0;j<Selection.objects.Length;j++)
        {
            Debug.Log("Project��" + j + "����������" + Selection.objects[j].name);
        }

    }

    public void OnFocus()
    {
        Debug.Log("ѡ������");
    }
    public void OnLostFocus()
    {
        Debug.Log("��ѡ����");
    }

    public void OnHierarchyChange()
    {
        Debug.Log("Hierarchy�б�");
    }
    public void OnProjectChange()
    {
        Debug.Log("Project�б�");
    }

}
