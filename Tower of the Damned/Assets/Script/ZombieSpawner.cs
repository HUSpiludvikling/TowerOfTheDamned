using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {
    [SerializeField]
    private GameObject Zombie;

    [SerializeField]
    [Range(2.1f,10.0f)]
    private float Delay = 5.0f;

    public TimeController timeController;

	void Start () {
        StartCoroutine(SpawnZombie(Delay));

	}

    /// <summary>
    /// Use this for Spawning Enemies
    /// </summary>
    /// <param name="delay">time between spawns</param>
    /// <returns></returns>
    IEnumerator SpawnZombie(float delay)
    {
        // the starting point
        while(timeController.CurrentTimeOfDay <= 0.23f || timeController.CurrentTimeOfDay >= 0.76f)
        {
            // Tells the program to wait for delay -/+2 seconds
            yield return new WaitForSeconds(delay + Random.Range(-2.0f, 2.0f));
            // Tells the program where to spawn the zombies
            Instantiate(Zombie, transform.position, Quaternion.identity );
        }
    }
}