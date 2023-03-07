using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float range;


    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xpos = h * range;

        transform.position = new Vector3(xpos, 2f, 0);
        Debug.Log("ValueReturned: " + h.ToString("F2"));
    }
}