using UnityEngine;
using System.Collections;

public class GroundGenerator : MonoBehaviour
{
    public GameObject ground;
    public Transform generationPoint;

    private float groundWidth;

    // Use this for initialization
    void Start()
    {
        groundWidth = ground.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + groundWidth, transform.position.y);

            Instantiate(ground, transform.position, transform.rotation);
        }
    }
}
