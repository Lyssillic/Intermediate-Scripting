using UnityEngine;
using System.Collections;

public class EnemyPlayer : MonoBehaviour
{
    // Static variables are shared across all instantances of a class
    public static int playerCount = 0;

    void Start()
    {
        // Increment the static variables to know how many 
        // objects of this class have been created
        playerCount++;
    }
}