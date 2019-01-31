using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour{

    [SerializeField] private Light sun;
    [SerializeField] float SecondsInFullDay = 120f;

    [Range(0, 1)]
    public float CurrentTimeOfDay = 0;

    private float TimeMultiplier = 0.1f;
    private float SunInitalIntensity;
    [SerializeField]
    private float nightScale;

    private void Start()
    {
        SunInitalIntensity = sun.intensity;
    }

    void Update()
    {
        UpdateSun();

  

        if (CurrentTimeOfDay >= 1)
        {
            CurrentTimeOfDay = 0;
        }

        if (CurrentTimeOfDay <= 0.23f || CurrentTimeOfDay >= 0.75f)
        {
            CurrentTimeOfDay += (Time.deltaTime / (SecondsInFullDay * nightScale));
        }
        else
        {
            CurrentTimeOfDay += (Time.deltaTime / SecondsInFullDay);
        }
    }

    void UpdateSun()
    {
        sun.transform.localRotation = Quaternion.Euler((CurrentTimeOfDay * 360f) - 90, 170, 0);

        float IntensityMultiplier = 1;

        if(CurrentTimeOfDay <= 0.23f || CurrentTimeOfDay >= 0.75f)
        {
            IntensityMultiplier = 0;
        }

        else if(CurrentTimeOfDay >= 0.25f)
        {
            IntensityMultiplier = Mathf.Clamp01((CurrentTimeOfDay - 0.23f) * (1 / 0.02f));
        }

        else if (CurrentTimeOfDay <= 0.73f)
        {
            IntensityMultiplier = Mathf.Clamp01(1 - ((CurrentTimeOfDay - 0.73f) * (1 / 0.02f)));
        }

        sun.intensity = SunInitalIntensity * IntensityMultiplier;
    }


}
