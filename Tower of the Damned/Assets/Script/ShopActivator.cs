using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ShopActivator : MonoBehaviour {

    [SerializeField]
    private ShopPanel shopPanel;

    private MouseLook mouseSetings;

    private FireingManagement fireingManagement;

    private float MouseX;
    private float MouseY;

	// Use this for initialization
	void Start () {
        shopPanel = GetComponentInChildren<ShopPanel>();

        mouseSetings = GetComponent<RigidbodyFirstPersonController>().mouseLook;
        fireingManagement = GetComponentInChildren<FireingManagement>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shop"))
        {
            shopPanel.SetStateRecursive(true);
            if (mouseSetings.XSensitivity != 0 && mouseSetings.YSensitivity != 0)
            {
                MouseX = mouseSetings.XSensitivity;
                MouseY = mouseSetings.YSensitivity;
            }
            mouseSetings.XSensitivity = 0;
            mouseSetings.YSensitivity = 0;
            mouseSetings.SetCursorLock(false);
            fireingManagement.InShop = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Shop"))
        {
            shopPanel.SetStateRecursive(false);
            mouseSetings.SetCursorLock(true);
            fireingManagement.InShop = false;

            if (MouseX != 0 && MouseY != 0)
            {
                mouseSetings.XSensitivity = MouseX;
                mouseSetings.YSensitivity = MouseY;
            }
            
        }
    }
}
