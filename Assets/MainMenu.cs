using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1); //Type in the scene as in the build index in file, build settings for the future once there are more scenes (2), or (1), etc.
    } 
}
