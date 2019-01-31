using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EventEnum
    {
        Fire,
        Move,
        ItemPickUp,
        ClickButton
    }

[RequireComponent(typeof(AudioSource))]
public class PlayOnEvent : MonoBehaviour {


    
    public EventEnum eventEnum;
    private AudioSource AudioSource;
	// Use this for initialization
	void Start () {
        AudioSource = GetComponent<AudioSource>();
		switch (eventEnum)
        {
            case EventEnum.Fire:
                SoundEvents.Fire.AddListener(EventPlayer); break;
            case EventEnum.Move:
                SoundEvents.Move.AddListener(EventPlayer); break
            case EventEnum.ItemPickUp:
                SoundEvents.ItemPickUp.AddListener(EventPlayer); break;
            case EventEnum.ClickButton:
                SoundEvents.ClickButton.AddListener(EventPlayer); break;

        }
	}

    private void EventPlayer()
    {
        AudioSource.Play();
    }
}
