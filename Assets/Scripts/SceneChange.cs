using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    
    public void ToGame()
    {
        SceneManager.LoadScene("2Game");
    }

    public void ToExit()
    {
        SceneManager.LoadScene("3Exit");
    }
}
