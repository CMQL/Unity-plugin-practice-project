using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InspectorDemo : MonoBehaviour
{
    public SerialClass serialTest;

    public int InsStat1;
    
    [HideInInspector]
    public int InsStat2;
    
    [NonSerialized]
    public int InsStat3;

    [SerializeField]
    public int InsStat4;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
