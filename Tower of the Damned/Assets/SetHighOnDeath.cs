using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHighOnDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Health>().DeathEvent.AddListener(() => {
            GameObject.FindGameObjectWithTag("SoundManagement").GetComponent<HighScore>().SetHighScore(Time.timeSinceLevelLoad / 60);
        });
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
