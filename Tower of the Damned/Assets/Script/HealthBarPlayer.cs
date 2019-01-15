using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarPlayer : MonoBehaviour {

    public Health healthScript;

    private Image barSprite;

	// Use this for initialization
	void Start () {
        barSprite = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        float percent = (healthScript.currentHP / healthScript.MaxHP);
        barSprite.fillAmount = percent;
	}
}
