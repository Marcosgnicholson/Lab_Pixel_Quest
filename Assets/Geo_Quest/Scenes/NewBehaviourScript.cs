using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float zoomiez = 2f;
    string String = "Hello";
    public string nextlevel = "Scene1_1";
    public string String2 { get; private set; }
    public int speed = 8;

    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("Hello World");
        string String2 = "World";
        Debug.Log(String + String2);

    }



    // Update is called once per frame
    void Update()
    {
        // rb.velocity = Vector2.left;
        rb = GetComponent<Rigidbody2D>();
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
        }*/

        // rb.velocity = new Vector2(-1, rb.velocity.y);
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, zoomiez);
                }
         if (Input.GetKeyDown(KeyCode.S))
        { transform.position += new Vector3(0, -zoomiez); }
         if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(zoomiez, 0)
                ;
        }
         if (Input.GetKeyDown(KeyCode.A))
        { transform.position += new Vector3(-zoomiez, 0); }
        Debug.Log(burger);
        burger++;
       */
        float xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xinput * speed, rb.velocity.y);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                    { }
                }
            case "Finish":
                SceneManager.LoadScene(nextlevel);
                break;



        }






    }
}
    
