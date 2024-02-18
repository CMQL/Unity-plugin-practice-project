using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
//[RequireComponent(typeof(InspectorDemo))]
[AddComponentMenu("Demo/TryDemo")]
public class ComponentDemo : MonoBehaviour
{

    [ContextMenu("ContextDemo")]
    public void ContextMenuDemo()
    {
        Debug.Log("ContextDemo activated");
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
