using TMPro;
using UnityEngine;

// LO1. Design and implement a class. 
public class UpdateUI : MonoBehaviour
{
    // LO1c. Utilize an initialization list
    // Review: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
    // SerializeField: Forces Unity to serialize a private field.
    [SerializeField] private GameObject ObjectPrefab;

    // Text that's used for the battery UI
    // TextMeshProUGUI: Determines if the size of the text container will be adjusted to fit the text object when it is first created
    private TextMeshProUGUI UIText;
    private string ObjectID;

    private void Awake()
    {
        UIText = GetComponent<TextMeshProUGUI>();
        ObjectID = ObjectPrefab.GetComponent<Object>().ID;
    }

    private void LateUpdate()
    {
        // PlayerPrefs.GetInt: Returns the value corresponding to key in the preference file if it exists. If it doesn't exist, it will return defaultValue
        UIText.text = PlayerPrefs.GetInt(ObjectID).ToString();
    }
}

