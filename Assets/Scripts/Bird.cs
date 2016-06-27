﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float jumpHeight = 15;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene("main");
        
    }

}
