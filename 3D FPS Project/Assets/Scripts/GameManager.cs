using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int winScene;
    public int loseScene;
    private Timer _timer;
    public TextMeshProUGUI targetText;
    private int _targetAmount;
    private string _sceneName = "Name";

    // Start is called before the first frame update
    void Start()
    {
        _timer = GameObject.Find("Game Manager").GetComponent<Timer>();
        Cursor.lockState = CursorLockMode.Locked;
        int floatingTarget = GameObject.FindGameObjectsWithTag("TargetFloating").Length;
        int standingTarget = GameObject.FindGameObjectsWithTag("TargetStanding").Length;
        _targetAmount = floatingTarget + standingTarget;
        targetText.text = "Targets: " + _targetAmount.ToString();
    }

    void Update()
    {
        if(_timer.GetTimeRemaining() <= 0)
        {
            SceneManager.LoadScene(loseScene);
        }
    }
    public void UpdateTargetAmount()
    {
       _targetAmount -= 1;
       targetText.text = "Targets: " + _targetAmount.ToString();

       if(_targetAmount <= 0)
       {
           //stop the timer
           GameObject.Find("Game Manager").GetComponent<Timer>().EndGameTimer();     
        //Send player to the win scene
        //SceneManager.LoadScene(winScene);

        //Send player to next scene in build setting  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }
    }
}
