using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

public class csPlanBrokenManager : MonoBehaviour
{
    public Object Spray_Seed;// 씨앗뿌릴때

    public static csPlanBrokenManager instance = null;
    public bool isInside = false;
   
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag.Equals("Player"))
        {
            isInside = true;
        }
    }
  

    void OnTriggerExit(Collider coll)
    {
        if (coll.tag.Equals("Player"))
        {
            isInside = false;
          
        }
    }
    public enum HitType
    {
        SPARY_SEED

    }


    public void SpraySeed(HitType hType)
    {
        if (!isInside)
            return;
        switch(hType)
        {
            case HitType.SPARY_SEED:
                GameObject part = (GameObject)Instantiate(Spray_Seed, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                Destroy(part, 0.5f);
                break;
        }
    }

   
}
