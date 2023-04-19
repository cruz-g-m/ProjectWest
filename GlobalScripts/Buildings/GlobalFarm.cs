using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFarm : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public GameObject buildingDescription;
    public float currentFood;
    public static float farmValue = 5f;
    public static bool turnOffButton = false;
    public GameObject foodStats;
    public GameObject foodStatsDisplay;
    public static float numberOfFarms;
    public static float farmPerSec;


    void Update()
    {
        currentFood = GlobalFood.FoodCount;
        
        foodStats.GetComponent<Text>().text = farmPerSec.ToString("N2") + "/Sec";
        fakeText.GetComponent<Text>().text = "(" + numberOfFarms + ") - " + "Farm \nCost: " + farmValue.ToString("N2") + " Food";
        realText.GetComponent<Text>().text = "(" + numberOfFarms + ") - " + "Farm \nCost: " + farmValue.ToString("N2") + " Food";

        buildingDescription.GetComponent<Text>().text = "Each farm increases food gathering per sec by 0,60 and food storage by * 1.2";

        if(currentFood >= farmValue){
            
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else{
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }

        if(turnOffButton == true){

            foodStatsDisplay.SetActive(true);
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
