using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehaviour: The base class from which every Unity script derives.
public class CollectObject : MonoBehaviour
{

    // Battery being placed and implemented in level
    private Object thisObject;

    private void Awake()
    {
        // Getting the battery's attributes through unity
        // GetComponent: Returns the component of Type type if the game object has one attached, null if it doesn't.
        thisObject = GetComponent<Object>();
    }

    // Collider2D: Parent class for collider types used with 2D gameplay.
    // Collision: Describes a "hurt box" or body range of a character.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Battery get's "collected" if the player comes in contact
        if (collision.CompareTag("Player"))
        {
            // PlayerPrefs: A class that stores Player preferences between game sessions
            PlayerPrefs.SetInt(thisObject.ID, PlayerPrefs.GetInt(thisObject.ID) + 1);
            Destroy(gameObject);
        }
    }
}
