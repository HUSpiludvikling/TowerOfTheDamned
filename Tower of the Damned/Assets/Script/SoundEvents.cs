using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoundEvents : MonoBehaviour {

    public static UnityEvent Fire;
    public static UnityEvent Move;
    public static UnityEvent ItemPickUp;
    public static UnityEvent ClickButton;

    private void Awake()
    {
        Fire = new UnityEvent();
        Move = new UnityEvent();
        ItemPickUp = new UnityEvent();
        ClickButton = new UnityEvent();
    }
}
