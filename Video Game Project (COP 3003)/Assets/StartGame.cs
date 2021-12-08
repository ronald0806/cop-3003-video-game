using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{

    // Obtaining level id from Unity
    public string LevelName;
    public void LoadLevel()
    {
        // Open up starting screen and selecting start
        SceneManager.LoadScene(LevelName);
    }
}
