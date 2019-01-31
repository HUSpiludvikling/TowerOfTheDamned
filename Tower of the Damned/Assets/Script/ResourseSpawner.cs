using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourseSpawner : MonoBehaviour {
    [SerializeField]
    private GameObject Resourse;

    
    [SerializeField]
    [Range(2.1f,10.0f)]
    private float Area = 5.0f;

    [SerializeField]
    [Range(2.1f,10.0f)]
    private float Delay = 5.0f;
	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnLumber(Delay));
	}

    /// <summary>
    /// use this to spawn resourses
    /// </summary>
    /// <param name="delay">time between spawns</param>
    /// <returns></returns>
    IEnumerator SpawnLumber(float delay)
    {
        // the starting point
        while(true)
        {
            // Tells the program to wait for delay -/+2 seconds
            yield return new WaitForSeconds(delay + Random.Range(-2.0f, 2.0f));
            // Tells the program where to spawn the zombies
            Instantiate(Resourse, transform.position+(Random.insideUnitSphere*Area), Quaternion.identity );
        }
    }
}