using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWordUI : MonoBehaviour
{
    public string MyText;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello World !!!");
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnGUI(){
        GUILayout.BeginArea(new Rect(10,10,200,200));
        GUILayout.Label(MyText);
        GUILayout.EndArea();
    }
}

// fungsi update() akan dijalankan terus menerus setiap frame.
// 