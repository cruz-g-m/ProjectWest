using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFood : MonoBehaviour{

    public static float FoodCount;
    public static float FoodStorage = 100f;
    public GameObject FoodDisplay;
    public float InternalFood;

    void Update(){
        InternalFood = FoodCount;
        FoodDisplay.GetComponent<Text>().text = "Food: " + InternalFood.ToString("N2") + " / " + FoodStorage.ToString("N2");
    }
}
