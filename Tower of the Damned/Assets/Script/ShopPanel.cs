using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanel : MonoBehaviour {

    //public bool CanActivte = false;

    private Image img;


	// Use this for initialization
	void Start () {
        img = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void SetStateRecursive(bool value)
    {
        img.enabled = value;
        foreach (Transform item in transform)
        {
            item.gameObject.SetActive(value);
        }
    }
}
