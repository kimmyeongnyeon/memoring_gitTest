using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csHitMotion : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotSpeed = 20f;
    void Update()
    {
        float x = Input.GetAxis("Vertical");
        x = x* Time.deltaTime * rotSpeed;

        transform.Rotate(Vector3.right * x);
    }
}
