using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftWood : MonoBehaviour{

    public GameObject statusBox;
    public static float WoodCost = 10f;

    public void ClickTheButton(){
             
        if(GlobalFood.FoodCount >= 10){

            GlobalFood.FoodCount -= WoodCost;
            GlobalWood.WoodCount += 1;
        } 
        else{

            statusBox.GetComponent<Text>().text = "Not enough food for transform.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        
 

    }
    

}
