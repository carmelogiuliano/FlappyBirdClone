using UnityEngine;
using System.Collections;

public class Scoreable : MonoBehaviour
{
    public int scoreValue;
    public GameController gameController;

	// Use this for initialization
	void Start ()
	{

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        gameController.UpdateScore(scoreValue);
    }
}
