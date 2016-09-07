using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;

    public GUISkin layout;

    Transform theBall;

	// Use this for initialization
	void Start ()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball").transform;
	}

    public static void Score(string wallID)
    {
        if (wallID == "rightWall")
        {
            PlayerScore1++;
        }
        else
        {
            PlayerScore2++;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
