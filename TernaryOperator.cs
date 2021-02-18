using UnityEngine;
using System.Collections;

public class TernaryOperator : MonoBehavior
{
    void Start()
    {
        int health = 10;
        string message;

        // This is a Ternary Operation example that chooses
        // a message based on the health variable
        message = health > 0 ? "Player is Alive!!" : "Player is DEAD.";
    }
}