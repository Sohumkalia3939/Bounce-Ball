using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocity = 10;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown("space"))
        TouchInput.ProcessTouches();

        if (TouchInput.Tap())
        {
            rb.velocity = Vector2.up * velocity;
        }

    }

   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Grass")
        {

        }
        else
        {
            gameManager.GameOver();
        }
    }
}
