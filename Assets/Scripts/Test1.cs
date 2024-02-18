using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test1 : MonoBehaviour
{
    public int mIntVal;
    public float mFloatVal;
    public string mStrVal;
    public TypeDemo mTypeDemo;
}

[Serializable]
public class TypeDemo
{
    public int tIntVal;
    public float tFloatVal;
    public string tStrVal;
}
