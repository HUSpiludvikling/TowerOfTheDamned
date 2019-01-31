using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoundEvents : MonoBehaviour {

    public static UnityEvent Fire;
    public static UnityEvent Move;
    public static UnityEvent Damage;
    public static UnityEvent Miss;
    public static UnityEvent ItemPickUp;
    public static UnityEvent ClickButton;

    private void Awake()
    {
        Fire = new UnityEvent();
        Fire.AddListener(DebugPrint);
        Move = new UnityEvent();
        Damage = new UnityEvent();
        Miss = new UnityEvent();
        ItemPickUp = new UnityEvent();
        ClickButton = new UnityEvent();
    }
    private void DebugPrint()
    {
        Debug.Log("´hej");
    }
}
