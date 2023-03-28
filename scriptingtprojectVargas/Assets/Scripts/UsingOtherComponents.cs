using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;


    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxcol;


    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxcol = otherGameObject.GetComponent<BoxCollider>();
    }


    void Start()
    {
        boxcol.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The Player has died " + yetAnotherScript.numberofPlayerDeaths + " times");
    }
}
