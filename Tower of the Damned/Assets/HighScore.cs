using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {
    public string HighScoreKey = "MyScore";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public float GetHighScore()
    {
        if (PlayerPrefs.HasKey(HighScoreKey))
        {
            return PlayerPrefs.GetFloat(HighScoreKey);
        }
        else
        {
            return 9999;
        }
    }

    public void SetHighScore(float HighScore)
    {
        if (HighScore < GetHighScore())
        {
            PlayerPrefs.SetFloat(HighScoreKey, HighScore);
        }
    }
}
