using UnityEngine;
using System.Collections;

public class UtilitiesExample : MonoBehavior
{
    void Start()
    {
        // You can access a static method by using the class name
        // and the dot operator
        int x = Utilities.Add(5, 6);
    }
}