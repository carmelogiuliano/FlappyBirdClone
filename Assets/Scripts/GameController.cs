using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    private int score;

	// Use this for initialization
	void Start ()
	{
	    score = 0;
        UpdateScore(score);
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void UpdateScore(int newScoreValue)
    {
        score += newScoreValue;
        Debug.Log("Score: " + score);
    }
}
