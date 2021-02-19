using UnityEngine;
using System.Collections;

public class SomeOtherClass2 : MonoBehaviour
{
    void Start()
    {
        SomeClass2 myClass = new SomeClass2();

        // In order to use this method you must
        // tell the method what type to replace 
        // 'T' with.
        myClass.GenericMethod<int>(5);
    }
}