using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateLives : MonoBehaviour
{
    //Script not in use
    public static void IncreaseLives()
    {
        KeepData.lives = KeepData.lives + 1;
    }

    
    public static void DecreaseLives()
    {
        KeepData.lives = KeepData.lives - 1;
    }
}
