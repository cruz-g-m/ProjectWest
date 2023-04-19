using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSawmill : MonoBehaviour
{
    
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentWood;
    public static float sawmillValue = 5f;
    public static bool turnOffButton = false;
    public GameObject woodStats;
    public GameObject woodStatsDisplay;
    public static float numberOfSawmills;
    public static float sawmillPerSec;

    
    void Update()
    {
        currentWood = GlobalWood.WoodCount;

        woodStats.GetComponent<Text>().text = sawmillPerSec.ToString("N2") + "/Sec";
        fakeText.GetComponent<Text>().text = "(" + numberOfSawmills + ") - " + "Sawmill \nCost: " + sawmillValue.ToString("N2") + " Wood";
        realText.GetComponent<Text>().text = "(" + numberOfSawmills + ") - " + "Sawmill \nCost: " + sawmillValue.ToString("N2") + " Wood";

        if(currentWood >= sawmillValue){
            
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else{
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
        
        if(turnOffButton == true){
            woodStatsDisplay.SetActive(true);
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }

    }
}
