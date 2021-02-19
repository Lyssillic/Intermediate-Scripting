using UnityEngine;
using System.Collections;

public class WarBand : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy2();
        Humanoid orc = new Orc();

        // Each variable has a reference to its own yell method
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}