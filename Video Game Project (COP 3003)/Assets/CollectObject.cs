using UnityEngine;

// LO1. Design and implement a class.
// LO2. Use subclassing to design simple class hierarchies that allow code to be reused for distinct subclasses.
// You subclass each time you write a C# script in Unity.
// MonoBehaviour: The base class from which every Unity script derives.
public class CollectObject : MonoBehaviour
{

    // Battery being placed and implemented in level
    // LO2a. Include comments describing the visibility inheritance model
    // LO6. Use object-oriented encapsulation mechanisms such as interfaces and private members.
    private Object thisObject;

    // LO6. Use object-oriented encapsulation mechanisms such as interfaces and private members.
    private void Awake()
    {
        // Getting the battery's attributes through unity
        // GetComponent: Returns the component of Type type if the game object has one attached, null if it doesn't.
        thisObject = GetComponent<Object>();
    }

    // LO6. Use object-oriented encapsulation mechanisms such as interfaces and private members.
    // Collider2D: Parent class for collider types used with 2D gameplay.
    // Collision: Describes a "hurt box" or body range of a character.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // LO3. Correctly reason about control flow in a program using dynamic dispatch. 
        // Battery get's "collected" if the player comes in contact
        if (collision.CompareTag("Player"))
        {
            // LO7. Define and use iterators and other operations on aggregates, including operations that take functions as arguments. 
            // PlayerPrefs: A class that stores Player preferences between game sessions
            PlayerPrefs.SetInt(thisObject.ID, PlayerPrefs.GetInt(thisObject.ID) + 1);
            Destroy(gameObject);
        }
    }
}


// Quality and Security: https://www.sonarsource.com/csharp/ 
