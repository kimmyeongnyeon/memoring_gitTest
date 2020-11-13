using System.Collections;
using System.Collections.Generic;
using TriangleNet.Voronoi.Legacy;
using UnityEngine;

public class csSprayWater : MonoBehaviour
{
    Transform waterParticle;
    //GameObject waterParticle;
    bool isCreate = false;
    void Start()
    {
        waterParticle = transform.Find("WaterPosition").Find("WaterParticle");//워터 파티클 찾기
      // waterParticle = GameObject.Find("WaterParticle");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("eulerAngle:x : " + transform.rotation.eulerAngles.x);
        //if (transform.rotation.eulerAngles.x > 30f)
        if(gameObject.tag=="Player")
        {// 물통이 x축으로 30보다 기울여졌을때
            if (!isCreate)
            {
               // Debug.Log("eulerAngle:x : " + transform.rotation.eulerAngles.x);
                waterParticle.GetComponent<ParticleSystem>().Play();// 물 파티클 생성
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);//스크립트 큐브 생성
                cube.transform.localScale = new Vector3(1f, 1f, 1f);// 큐브 크기
                cube.transform.position = waterParticle.position;// 큐브 위치
                cube.transform.name = "Water Cube";
                cube.tag = "Water Cube";
                cube.AddComponent<Rigidbody>();
                cube.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 200f, 200f));
                cube.GetComponent<MeshRenderer>().enabled = false;
                csPlantGrow plant = GetComponent<csPlantGrow>();
                plant.SprayWater();
                isCreate = true;
            }
        }
        else
        {
            waterParticle.GetComponent<ParticleSystem>().Stop();//파티클 중지
            isCreate = false;
        }
    }
}
