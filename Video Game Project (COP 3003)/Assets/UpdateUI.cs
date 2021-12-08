using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateUI : MonoBehaviour
{
    // SerializeField: Forces Unity to serialize a private field.
    [SerializeField] private GameObject ObjectPrefab;
    
    // Text that's used for the battery UI
    private TextMeshProUGUI UIText;
    private string ObjectID;

    private void Awake()
    {
        UIText = GetComponent<TextMeshProUGUI>();
        ObjectID = ObjectPrefab.GetComponent<Object>().ID;

    }

    private void LateUpdate()
    {

        // PlayerPrefs: A class that stores Player preferences between game sessions
        UIText.text = PlayerPrefs.GetInt(ObjectID).ToString();
    }
}
