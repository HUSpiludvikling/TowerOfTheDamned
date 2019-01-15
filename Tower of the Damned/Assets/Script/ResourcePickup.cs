using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcePickup : MonoBehaviour
{
    public enum ResourceType { Lumber, Stone }
    public ResourceType type;
    public int amount;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (type == ResourceType.Lumber)
            {
                collision.gameObject.GetComponent<ResourceCollection>().AddLumber(amount);
                Destroy(gameObject);
            }
            else if (type == ResourceType.Stone)
            {
                collision.gameObject.GetComponent<ResourceCollection>().AddStone(amount);
                Destroy(gameObject);
            }
        }
    }
}
