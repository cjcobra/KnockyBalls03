using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    public static LevelManager Instance { get { return instance; } }

    private int levelNumber;
    public Text levelText;
    private static int bulletCount;
    public Text bulletCountText;

    private void Start()
    {
        Debug.Log("LevelManager:  Start()");
        instance = this;

        //Recall Level
        levelNumber = PlayerPrefs.GetInt("currentLevel");

        if (levelNumber < 1)
        {
            levelNumber = 1;
        }

        ////////////////////////////////////////////////////////////////////////////////////
        // Always set to Level 1 (For Testing) 
 //       levelNumber = 1;
        // Save Level
        PlayerPrefs.SetInt("currentLevel", levelNumber);
        ////////////////////////////////////////////////////////////////////////////////////

        DisplayLevelText();
        LevelTracker();
    }

    public void DisplayLevelText()
    {
        Debug.Log("LevelManager:  DisplayLevelText()");
        Debug.Log("Level: " + levelNumber);

        //Recall Level
        levelNumber = PlayerPrefs.GetInt("currentLevel");

        levelText.text = "Level: " + levelNumber.ToString();   // ScoreText.text = "Score: " + score.ToString();
        bulletCountText.text = "Bullets Fired: " + bulletCount.ToString();

    }

    public void LevelTracker()
    {
        Debug.Log("LevelManager:  LevelTracker() - Recall's Level");

        //Recall Level
        levelNumber = PlayerPrefs.GetInt("currentLevel");
        levelText.text = "Level: " + levelNumber.ToString();   // ScoreText.text = "Score: " + score.ToString();

    }

    public void GoToLevel()
    {
        // Start button linked to this
        Debug.Log("LevelManager:  GoToLevel()");
        Debug.Log("Level: " + levelNumber);
        SceneManager.LoadScene("Level" + levelNumber);  //SceneManager.LoadScene("Level" + levelNumber);
        DisplayLevelText();

    }

    public void LevelComplete()
    {
        Debug.Log("LevelManager:  LevelComplete()");

        // Recall Bullet Count
        bulletCount = playerScript02.saveBulletCount;
        
        SceneManager.LoadScene("LevelComplete");
    
    }

    public void GoToNextLevel()
    {
        // Level Complete Button linked to this
        Debug.Log("LevelManager:  GoToNextLevel()");

        levelNumber++;
        // Save Level
        PlayerPrefs.SetInt("currentLevel", levelNumber);
        GoToLevel();
    }

    public void ResetToLevel1()
    {
        Debug.Log("LevelManager:  ResetToLevel1()");

        levelNumber = 1;
        // Save Level
        PlayerPrefs.SetInt("currentLevel", levelNumber);

    }

    public void LevelUnlocker()
    {
        Debug.Log("LevelManager:  LevelUnlocker()");
    }



    public void MainMenu()
    {
        Debug.Log("LevelManager:  MainMenu()");
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartGame()
    {
        MainMenu();
        ResetToLevel1();
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    public void TogglePauseMenu()
    {
     //   pauseMenu.SetActive(!pauseMenu.activeSelf);
     //   Time.timeScale = (pauseMenu.activeSelf) ? 0 : 1;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        Debug.Log("LevelManager:  MainMenu()");
//        SceneManager.LoadScene("MainMenu");
    }

    /*
    public void Victory()
    {
        // Debug.Log(levelDuration);

        // Stop Timer
        Time.timeScale = 0;

        foreach (Transform t in endMenu.transform.parent)
        {
            t.gameObject.SetActive(false);
        }

        endMenu.SetActive(true);

    //    levelDuration = Time.time - startTime;
    //    string minutes = ((int)levelDuration / 60).ToString("00");
    //    string seconds = (levelDuration % 60).ToString("00.00");
    //    endTimerText.text = minutes + ":" + seconds;

        if (levelDuration < goldTime)
        {
            // cj   CompleteGameManager.Instance.currency += 150;
            endTimerText.color = Color.yellow;
        }
        else if (levelDuration < silverTime)
        {
            // cj   CompleteGameManager.Instance.currency += 75;
            endTimerText.color = Color.gray;
        }
        else
        {
            // cj   CompleteGameManager.Instance.currency += 30;
            endTimerText.color = new Color(0.8f, 0.5f, 0.2f, 1.0f);
        }


        CompleteGameManager.Instance.Save();

        string saveString = "";

        LevelData level = new LevelData(SceneManager.GetActiveScene().name);
        saveString += (level.BestTime > levelDuration || level.BestTime == 0.0f) ? levelDuration.ToString() : level.BestTime.ToString();
        saveString += '&';
        saveString += silverTime.ToString();
        saveString += '&';
        saveString += goldTime.ToString();
        PlayerPrefs.SetString(SceneManager.GetActiveScene().name, saveString);

    }
    */


}
