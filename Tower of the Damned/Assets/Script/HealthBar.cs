﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public interface IBarRepresentable
{
    int currentHP { get; set; }
    int MaxHP { get; set; }
    UnityEvent TakeDamageEvent { get; set; }
}


public class HealthBar : MonoBehaviour {
    public GameObject healthScript;
    IBarRepresentable Barscript;

    Image img;
    float originalImageSizeDeltaX;

    float originalAnchoredPositionX;

    float percentage = 1f;

    int currentHealth;
    int maximumHealth;

    public bool EnableAlignmentCorrection = true;

    // Use this for initialization
	void Start () {
        Barscript = healthScript.GetComponent<IBarRepresentable>();

        if(Barscript == null)
        {
            GetComponentInParent<IBarRepresentable>();
        }

        img = GetComponent<Image>();
        originalImageSizeDeltaX = img.rectTransform.sizeDelta.x;

        //Not needed right now, as it is always zero, but this should prevent some future issues!
        originalAnchoredPositionX = img.rectTransform.anchoredPosition.x;

        currentHealth = Barscript.currentHP;
        maximumHealth = Barscript.MaxHP;

        Barscript.TakeDamageEvent.AddListener(UpdateHealthBarRepresentation);

    }


    /// <summary>
    /// Updates the health bar
    /// </summary>
    public void UpdateHealthBarRepresentation()
    {
        currentHealth = Barscript.currentHP;
        maximumHealth = Barscript.MaxHP;
        percentage = (float)currentHealth / (float)maximumHealth; // floatcasting to avoid integer rounding.
        
        if (percentage >= 0f)
        {
            CorrectBarSize();

            //Assures correct alignment
            if (EnableAlignmentCorrection) CorrectAlignment();
        }
    }

    private void CorrectBarSize()
    {
        img.rectTransform.sizeDelta = new Vector2(originalImageSizeDeltaX * percentage, img.rectTransform.sizeDelta.y);
    }

    private void CorrectAlignment()
    {
        img.rectTransform.anchoredPosition = new Vector3((originalAnchoredPositionX + (maximumHealth - currentHealth) * (img.rectTransform.localScale.x / 2f)), 0f);
    }
}

