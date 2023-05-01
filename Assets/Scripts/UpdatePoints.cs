using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePoints : MonoBehaviour
{
    public Text pointsText;
    public static int points;
    public Button increasePoints;
    public Button decreasePoints;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        pointsText.text = points.ToString();
    }

    public void IncreasePointValue()
    {
        points = points + 1;
        pointsText.text = points.ToString();
    }

    public void DecreasePointValue()
    {
        points = points - 1;
        pointsText.text = points.ToString();
    }
}
