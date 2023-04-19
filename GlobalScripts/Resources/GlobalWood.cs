using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalWood : MonoBehaviour{

    public static float WoodCount;
    public static float WoodStorage = 100f;
    public GameObject WoodDisplay;
    public float InternalWood;

    void Update(){
        InternalWood = WoodCount;
        WoodDisplay.GetComponent<Text>().text = "Wood: " + InternalWood.ToString("N2") + " / " + WoodStorage.ToString("N2");
    }
}
