using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bannanas;

    private int stapler;
    private int sellotape;


    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies Total: " + answer);
    }
}