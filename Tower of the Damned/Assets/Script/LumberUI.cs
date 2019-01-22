using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LumberUI : MonoBehaviour {

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
    void Update () {
        Text.text = "Lumber:" + resourceCollection.Lumber;
	}

}
