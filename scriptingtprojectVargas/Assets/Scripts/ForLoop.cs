using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int numEnimies = 3;


    void Start()
    {
        for (int i = 0; i < numEnimies; i++)
        {

            Debug.Log("Creating enemy number: " + i);
        }
    }
}