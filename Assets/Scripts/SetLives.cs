using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLives : MonoBehaviour
{
    public Text livesText;
    public Button increaseLives;
    public Button decreaseLives;

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = KeepData.lives.ToString();
    }

    void Update()
    {
        //livesText.text = KeepData.lives.ToString();
    }

    public void IncreaseLives()
    {
        KeepData.lives += 1;
        livesText.text = KeepData.lives.ToString();
    }


    public void DecreaseLives()
    {
        KeepData.lives -= 1;
        livesText.text = KeepData.lives.ToString();
    }
}
