using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test2:MonoBehaviour
{
    public EnumDemo mEnumDemo;
    public int mInt;
    public bool mBool;
    public float mFloat;
    public string mStr;
    public Color mColor;

}

[Serializable]
public enum EnumDemo
{
    None,
    Bool,
    Int,
    Float,
    String,
    Color,
}
