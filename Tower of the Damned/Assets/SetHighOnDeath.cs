using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SetHighOnDeath : MonoBehaviour {
    private MouseLook mouseSetings;
    // Use this for initialization
    void Start () {
        GetComponent<Health>().DeathEvent.AddListener(() => {
            GameObject.FindGameObjectWithTag("SoundManagement").GetComponent<HighScore>().SetHighScore(Time.timeSinceLevelLoad / 60);
        });
        mouseSetings = GetComponent<RigidbodyFirstPersonController>().mouseLook;

        GetComponent<Health>().DeathEvent.AddListener(EnableMouse);

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void EnableMouse()
    {
        mouseSetings.XSensitivity = 0;
        mouseSetings.YSensitivity = 0;
        mouseSetings.SetCursorLock(false);
    }
}
