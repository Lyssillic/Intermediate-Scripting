using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehavior
{
    void Start()
    {
        // Access a static variable by using the class name
        // and the dot operator.
        int x = EnemyPlayer.playerCount;
    }
}