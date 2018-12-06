using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieTower : MonoBehaviour {

    [SerializeField]
    string SceneName = "Lose Scene";

	// Use this for initialization
	void Start () {
        GetComponent<Health>().DeathEvent.AddListener(Die);
	}

    void Die()
    {
        SceneManager.LoadScene(SceneName);
    }
}