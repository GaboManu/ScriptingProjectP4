using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxisExample : MonoBehaviour
{
    public TextAlignment horizontalValueDisplayText;
    public TextAlignment verticalValueDisplayText;
    public float hRange;
    public float vRange;
    private float vPos;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;

        transform.position = new Vector3(xPos, 0, vPos);
        Debug.Log("ValueReturned: " + h.ToString("F2"));
    }
}        