using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour{

    public GameObject AutoFood;
    public GameObject AutoWood;

    public GameObject farmStatsPanel;
    public GameObject buttonShowDetailTurnOff;
    public GameObject buttonCloseDetail;
    public GameObject buttonCloseDetailTurnOff;

    public void StartAutoFood(){

        AutoFood.SetActive(true);
        GlobalFood.FoodCount -= GlobalFarm.farmValue;
        GlobalFood.FoodStorage *= 1.2f;
        GlobalFarm.farmValue *= 1.2f;
        GlobalFarm.turnOffButton = true;
        GlobalFarm.farmPerSec += 0.6f;
        GlobalFarm.numberOfFarms += 1;

    }

    public void StartAutoWood(){

        AutoWood.SetActive(true);
        GlobalWood.WoodCount -= GlobalSawmill.sawmillValue;
        GlobalSawmill.sawmillValue *= 1.2f;
        GlobalSawmill.turnOffButton = true;
        GlobalSawmill.sawmillPerSec += 0.3f;
        GlobalSawmill.numberOfSawmills += 1;
    }

    public void UpgradeStorage(){
        GlobalWood.WoodCount -= GlobalStorage.storageValue;
        GlobalStorage.storageValue *= 1.2f;
        GlobalWood.WoodStorage *= 1.2f;
        GlobalFood.FoodStorage *= 1.3f;
        GlobalStorage.turnOffButton = true;
        GlobalStorage.numberOfStorages +=1;

    }

    public void FarmShowDetails(){
        
        farmStatsPanel.SetActive(true);
        buttonCloseDetail.SetActive(true);
        buttonShowDetailTurnOff.SetActive(false);
    }

    public void FarmCloseDetails(){
        farmStatsPanel.SetActive(false);
        buttonCloseDetail.SetActive(false);
        buttonShowDetailTurnOff.SetActive(true);
    }

}
