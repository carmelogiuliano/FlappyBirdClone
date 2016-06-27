using UnityEngine;
using System.Collections;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstacle;
    public Transform generationPoint;
    public float frequency;

    private bool isSpawned;

	// Use this for initialization
	void Start ()
	{
	    isSpawned = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float test = transform.position.x + frequency;
        if (!isSpawned && (test < generationPoint.position.x))
        {
            Debug.Log("obstacle");
            var obstaclePosition = new Vector3(generationPoint.position.x, transform.position.y);
            Instantiate(obstacle, obstaclePosition, transform.rotation);
            isSpawned = true;
        }
	}
}
