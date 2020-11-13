using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csWaterTouch : MonoBehaviour
{
    public float rotSpeed = 20f;
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        v = v * Time.deltaTime * rotSpeed;

        transform.Rotate(Vector3.right * v);
    }
}
