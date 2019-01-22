using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoneUI : MonoBehaviour {

    [SerializeField]
    private ResourceCollection resourceCollection;

    Text Text;

    private void Awake()
    {
        if (resourceCollection == null)
        {
            resourceCollection = GameObject.FindGameObjectWithTag("Player").GetComponent<ResourceCollection>();
        }
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Stone:" + resourceCollection.Stone;
    }

}
