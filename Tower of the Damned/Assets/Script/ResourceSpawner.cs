using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSpawner : MonoBehaviour {
    [SerializeField]
    private GameObject[] Resourses; 
    public ResourcePickup.ResourceType resource;

    public int MaxLumber;
    public int MaxStone;
    public static int Lumber;
    public static int Stone;
    
    [SerializeField]
    [Range(2.1f,10.0f)]
    private float Area = 5.0f;

    [SerializeField]
    [Range(2.1f,10.0f)]
    private float Delay = 5.0f;
	// Use this for initialization
	void Start () {
        Stone=0;
        Lumber = 0;
        switch (resource)
        {
            case ResourcePickup.ResourceType.Lumber:
                StartCoroutine(SpawnLumber(Delay));
                break;
            case ResourcePickup.ResourceType.Stone:
                StartCoroutine(SpawnStone(Delay));
                break;
            default:
                break;
        }
        
	}

    /// <summary>
    /// use this to spawn resourses
    /// </summary>
    /// <param name="delay">time between spawns</param>
    /// <returns></returns>
    IEnumerator SpawnLumber(float delay)
    {
        // the starting point
        while (true)
        {
            // Tells the program to wait for delay -/+2 seconds
            yield return new WaitForSeconds(delay + Random.Range(-2.0f, 2.0f));
            // Tells the program where to spawn the zombies
            if (Lumber <=MaxLumber)
            {
                Lumber++;
                Instantiate(Resourses[0], transform.position + (Random.insideUnitSphere * Area), Quaternion.identity);
            }
           
        }
    }
    IEnumerator SpawnStone(float delay)
    {
        // the starting point
        while (true)
        {
            // Tells the program to wait for delay -/+2 seconds
            yield return new WaitForSeconds(delay + Random.Range(-2.0f, 2.0f));
            if (Stone<=MaxStone)
            {
                Stone++;
                Instantiate(Resourses[1], transform.position + (Random.insideUnitSphere * Area), Quaternion.identity);
            }
            
        }
    }
}