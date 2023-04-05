using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] players;

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for (int i =0; 1< players.Length; i++)
        {
            Debug.Log("Players number " + i + " is names " + players[i].name);
        }
    }
}