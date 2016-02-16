using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public float timeLeft = 50.0f;
    public Text secondsLeftText;
    private string timeLeftString;

    // Use this for initialization
    void Start ()
    {
      
	}
    public void Update()
    {

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0.0f)
        {
            // End the level here.
        }
        timeLeftString = timeLeft.ToString("F0");
        secondsLeftText.text = timeLeftString;
    }
}
