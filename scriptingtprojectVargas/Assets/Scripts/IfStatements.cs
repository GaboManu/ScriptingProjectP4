using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
    {
        if (coffeTemperature > hotLimitTemperature)
        {
            print("Coffe is too hot.");
        }
        else if (coffeTemperature < coldLimitTemperature)
        {
            print("Coffe is too cold.");
        }
        else
        {
            print("Coffe is just right.");
        }
    }
}