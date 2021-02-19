using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    // The required method of the IKillable interface
    public void Kill()
    {
        // Kill things
    }
    
    // The required method of the IDamageable interface
    public void Damage(float damageTaken)
    {
        // Do damage to creature
    }
}