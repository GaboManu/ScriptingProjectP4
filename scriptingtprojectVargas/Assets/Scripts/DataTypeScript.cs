using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos = new Vector3(3, 2, 0);


        Transform tran = transform;
        tran.position = new Vector3(3, 2, 0);
    }
}