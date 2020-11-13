using System.Collections;
using System.Collections.Generic;
using UnityEditor.Recorder;
using UnityEditor.UIElements;
using UnityEngine;

public class csPlantHit : MonoBehaviour
{
    public GameObject ChangePlant;// 밭 오브젝트 교체
    public Transform HitGround;// 땅 파티클 효과
    bool isCreate = false;


    

    private void OnTriggerEnter(Collider other)// 밭에 들어왔을때
    {
        if (other.gameObject.tag == "Player")
        {
            isCreate = true;
            Debug.Log("Crush");
            HitGround = Instantiate(HitGround, transform);
          /*  ChangePlant = Instantiate(ChangePlant, transform);*/
          ChangePlant = Instantiate(ChangePlant, HitGround);
         
        }
    }

    private void Start()
    {
        //Resources.Load<GameObject>("Prefabs/HitGround");
    }

    //private void Update()
    //{
    //    if(transform.rotation.eulerAngles.x>40f )
    //    {
    //        if (!isCreate) 
    //        { 
    //        Debug.Log("Plan Crush");
            
    //        //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);// 스크립트
    //        //cube.transform.localScale = new Vector3(1f, 1f, 1f);// 큐브 크기
    //        //cube.transform.position = HitGround.position;// 큐브위치
    //        //cube.tag = "Hit Cube";
    //        //cube.AddComponent<Rigidbody>();
    //        //cube.GetComponent<Rigidbody>().AddForce(new Vector3(200f, 200f, 200f));
    //        //cube.GetComponent<MeshRenderer>().enabled = true;
    //            Resources.Load<ParticleSystem>("Prefabs/HitGround").Play();
    //            HitGround = Instantiate(HitGround, transform);
    //            ChangePlant = Instantiate(ChangePlant, transform);
               
    //            isCreate = true;
    //        }

    //        else
    //        {
    //            HitGround.GetComponent<ParticleSystem>().Stop();
    //            isCreate = false;
    //        }
    //    }

  //  }
    
}
