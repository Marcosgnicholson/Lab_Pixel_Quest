using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winwin : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Scene_1 1";

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
    }
}