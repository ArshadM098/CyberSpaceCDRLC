using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShift : MonoBehaviour
{
    public Material DayMat;
    public Material NightMat;
    public GameObject SunSource;
    public bool isDay = true;

    public GameObject[] Models;
    // Start is called before the first frame update
    // Update is called once per frame
    public void ToNight() {
        RenderSettings.skybox = NightMat;
        SunSource.SetActive(false);
        int x = Models.Length;
        for (int i = 0; i < x; i++)
        {
            Models[i].SetActive(true);
        }
    }
     private void ToDay()
    {
        RenderSettings.skybox = DayMat;
        int x = Models.Length;
        for (int i = 0; i < x; i++) {
            Models[i].SetActive(false);
        }
        SunSource.SetActive(true);
    }

    public void toggleScene() {
        if (isDay)
        {
            this.ToNight();
            isDay = false;
        }
        else {
            this.ToDay();
            isDay = true;
        }
        
    }
}
