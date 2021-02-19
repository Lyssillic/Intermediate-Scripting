using UnityEngine;
using System.Collections;

public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();

        // The specific Add method called will depend on
        // the arguments passed in
        myClass.Add(1, 2);
        myClass.Add("Hello, ", "World!"); // <- I'm getting a tattoo of this saying in May :3
    }
}