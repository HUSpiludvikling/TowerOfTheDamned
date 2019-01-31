using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireingManagement : MonoBehaviour {
    public GameObject Arrow;
    public string Firekey = "Fire1";
    [System.NonSerialized]
    public bool InShop = false;

    public int Damage;

    public List<int> AdditionalDamage;

    [Range(1f,50f)]
    public float ForceMod = 5f;
	// Use this for initialization
	void Start () {
        AdditionalDamage = new List<int>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown(Firekey) && !InShop)
        {
            Fire();
        }
	}

    private void Fire()
    {
        SoundEvents.Fire.Invoke();
        GameObject TempArrow;
        TempArrow = Instantiate(Arrow, transform.position + transform.forward, transform.rotation * Arrow.transform.rotation);
        TempArrow.GetComponent<Rigidbody>().AddForce(transform.forward * ForceMod, ForceMode.Impulse);
        int sumAddDamage = 0;
        foreach (int addDamage in AdditionalDamage)
        {
            sumAddDamage += addDamage;
        }
        int totalDamage = Damage + sumAddDamage;
        TempArrow.GetComponent<DealDamage>().SetDamage(totalDamage);
    }

    public void UpgradeDamage(int moreDamage)
    {
        AdditionalDamage.Add(moreDamage);
    }
}
