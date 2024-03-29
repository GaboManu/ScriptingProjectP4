using UnityEngine;

public class AxisRawExample : MonoBehaviour
{
    public float range;
    public TextAlignment textOutput;


    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        Debug.Log("ValueReturned: " + h.ToString("F2"));
    }
}