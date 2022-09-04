using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWordUI : MonoBehaviour
{
    public string MyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(MyText);
    }
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10,10,200,200));
        GUILayout.Label(MyText);
        GUILayout.EndArea();
    }
}
