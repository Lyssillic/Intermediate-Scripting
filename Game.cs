using UnityEngine;
using System.Collections;

public class Game : MonoBehavior
{
    void Start()
    {
        Player myPlayer = new Player();

        // Properties can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
        
    }
}