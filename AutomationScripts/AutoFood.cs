using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFood : MonoBehaviour{
   
   public bool GatheringFood = false;
   public static float FoodIncrease = 1f;
   public float InternalIncrease;


    void Update(){

        FoodIncrease = GlobalFarm.farmPerSec;

        InternalIncrease = FoodIncrease;
        
        if(GatheringFood == false){
            GatheringFood = true;
            StartCoroutine(GatheringTheFood());
        }
    }

    IEnumerator GatheringTheFood(){
        if(GlobalFood.FoodCount < GlobalFood.FoodStorage){
            GlobalFood.FoodCount += InternalIncrease;
            yield return new WaitForSeconds(1);
            GatheringFood = false;
        }
    }
}
