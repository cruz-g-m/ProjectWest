using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalStorage : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentWood;
    public static float storageValue = 5f;
    public static bool turnOffButton = false;
    public static float numberOfStorages;
    
    void Update()
    {
        currentWood = GlobalWood.WoodCount;

        fakeText.GetComponent<Text>().text = "(" + numberOfStorages + ") - " + "Storage \nCost: " + storageValue.ToString("N2") + " Wood";
        realText.GetComponent<Text>().text = "(" + numberOfStorages + ") - " + "Storage \nCost: " + storageValue.ToString("N2") + " Wood";

        if(currentWood >= storageValue){

            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else{
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }

        if(turnOffButton == true){
            
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
