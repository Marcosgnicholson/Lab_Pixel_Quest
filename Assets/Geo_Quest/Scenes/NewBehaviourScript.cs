using System.Collections;
using System.Collections.Generic;
using UnityEngine;
int burger = 3;

public class NewBehaviourScript : MonoBehaviour
{

    string String = "World";

    public string String2 { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        string String = "hihi ";
        Debug.Log(String + String2);
      
    }

    // Update is called once per frame
    void Update(int burger)
    {
        Debug.Log(burger);
        burger++;
    }
}
