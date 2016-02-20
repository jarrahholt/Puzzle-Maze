using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {

    public float time = 50.0f;
    public Text secondsLeftText;
    private string timeLeftString;
    public string loseScene;
    
    // Use this for initialization
    void Start ()
    {
      
	}
    public void Update()
    {

        time += Time.deltaTime;

        //if (timeLeft <= 0.0f)
        //{
        //    SceneManager.LoadScene(loseScene);
        //}
        timeLeftString = time.ToString("F0");
        secondsLeftText.text = timeLeftString;
    }
}
