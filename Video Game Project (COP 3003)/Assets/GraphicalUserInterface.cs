// Name: Ronald Chatelier
// Course: COP 3003
// file: GraphicalUI.cs

// Quality and Security: https://www.sonarsource.com/csharp/
// Style and Structure: https://google.github.io/styleguide/csharp-style.html

// Style and structure of the program is included with the naming rules,
// organization, and whitespace rules.
// Quality and security is the use of sonarsource, which will sync
// this project's repository on GitHub in order to identify
// the reliability, maintainability, and security of the program.

using UnityEngine;
using TMPro;


// LO1. Design and implement a class. 
public class GraphicalUI : MonoBehaviour
{
    // LO1c. Utilize an initialization list.
    // SerializeField: Forces Unity to serialize a private field.
    [SerializeField] private GameObject ObjectPrefab;

    // LO6. Use object-oriented encapsulation mechanisms such as
    // interfaces and private members.
    // Text that's used for the battery UI.
    // TextMeshProUGUI: Determines if the size of the text container
    // will be adjusted to fit the text object when it is first created.
    private TextMeshProUGUI UIText;
    private string ObjectID;

    // LO6. Use object-oriented encapsulation mechanisms
    // such as interfaces and private members.
    private void Awake()
    {
        UIText = GetComponent<TextMeshProUGUI>();
        ObjectID = ObjectPrefab.GetComponent<Object>().ID;
    }

    // LO6. Use object-oriented encapsulation mechanisms
    // such as interfaces and private members.
    private void LateUpdate()
    {
        // PlayerPrefs.GetInt: Returns the value corresponding
        // to key in the preference file if it exists.
        // If it doesn't exist, it will return defaultValue.
        UIText.text = PlayerPrefs.GetInt(ObjectID).ToString();
    }
}