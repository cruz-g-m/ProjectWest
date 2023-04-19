using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftFood : MonoBehaviour{


    public void ClickTheButton(){
        if(GlobalFood.FoodCount < GlobalFood.FoodStorage){
            GlobalFood.FoodCount += 1;
        }
        else{
            GlobalFood.FoodCount += 0;
        }
        

    }
    

}
