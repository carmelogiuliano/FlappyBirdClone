using UnityEngine;
using System.Collections;

public class EnvironmentMovement : MonoBehaviour
{
    public float speed;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
