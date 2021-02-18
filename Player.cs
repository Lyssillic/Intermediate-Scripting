using UnityEngine;
using System.Collections;

public class Player
{
    // Member variables can be referred to as fields
    private int experience;

    // Experience is a basic property
    public int Experience
    {
        get 
        {
            return experience;
        }
        set 
        {
            experience = value;
        }
    }
    
    // Level is a property that converts experience
    // points into the level of a player automatically
    public int Level 
    {
        get 
        {
            return experience / 1000;
        }
        set 
        {
            experience = value * 1000;
        }
    }

    // Auto-implemented property example
    public int Health { get; set;}
}