using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csHitMotionConnect : MonoBehaviour
{
    //기존 밭 사라지는 스크립트
    public bool isInside = false;
    public GameObject DestoryPlant;// 기존 오브젝트 삭제

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Debug.Log("HitGround Action");
            isInside = true;
            Destroy(DestoryPlant, 2f);
        }
    

    }
}
