using UnityEngine;
using System.Collections;

// Here is a generic class. Notice generic type 'T'.
// 'T' will be replaced with an actual type, as will
// instances of the type 'T' used in the class
public class GenericClass <T> 
{
    T item;
    
    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}