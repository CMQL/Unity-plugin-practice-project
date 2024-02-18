using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuTest : MonoBehaviour
{

    [MenuItem("Menu/Test")]
    public static void Test()
    {
        Debug.Log("First test menu clicked");
    }

    [MenuItem("Menu/DirectWithKey _D")]
    public static void KeyTest() 
    {
        Debug.Log("This one can be called by key");
    }

    [MenuItem("Menu/KeyWithShift #S")]
    public static void ShiftKeyTest()
    {
        Debug.Log("This one is called by shift-key");
    }

    [MenuItem("Menu/KeyWithCtrl %C")]
    public static void CtrlKeyTest()
    {
        Debug.Log("This one is called by ctrl-key");
    }

    [MenuItem("Menu/KeyWithAlt &A")]
    public static void AltKeyTest()
    {
        Debug.Log("This one is called by alt-key");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
