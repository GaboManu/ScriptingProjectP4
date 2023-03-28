using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject myobject;


    void Start()
    {
        Debug.Log("Active Self: " + myobject.activeInHierarchy);
        Debug.Log("Active in Hierarchy" + myobject.activeInHierarchy);
    }
}