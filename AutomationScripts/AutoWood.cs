using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWood : MonoBehaviour
{
    public bool GatheringWood = false;
    public static float WoodIncrease = 1f;
    public float InternalIncrease;


    void Update()
    {
        WoodIncrease = GlobalSawmill.sawmillPerSec;

        InternalIncrease = WoodIncrease;

        if(GatheringWood == false) {
            GatheringWood = true;
            StartCoroutine(GatheringTheWood());
        }
    }

    IEnumerator GatheringTheWood(){
        if(GlobalWood.WoodCount < GlobalWood.WoodStorage){
            GlobalWood.WoodCount += InternalIncrease;
            yield return new WaitForSeconds(1);
            GatheringWood = false;
        }
    }
}
