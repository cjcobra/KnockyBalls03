using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collisionDetection : MonoBehaviour
{

    public Text ScoreText;
    public Text YouWon;
    private int countBricks;  // was float
    public LevelManager CallScript;

    // Start is called before the first frame update
    void Start()
    {
        countBricks = GameObject.FindGameObjectsWithTag("Brick").Length;
        //Debug.Log(countBricks);

        YouWon.text = "";

        Debug.Log("collisionDetection:  Bricks Left: " + countBricks);
        SetScoreText();
    }

    void OnCollisionEnter(Collision col)
    {
     //   Debug.Log (gameObject.name + " has collided with " + col.gameObject.name);

        if (col.gameObject.tag == "Brick")   // "col.gameObject.name == "Brick"
        {
            countBricks = countBricks - 1;
            Destroy(col.gameObject);
            SetScoreText();

            Debug.Log("Bricks Left: " + countBricks);
            
        }
    }

    void SetScoreText()
    {

        ScoreText.text = "Bricks Left: " + countBricks.ToString();   // ScoreText.text = "Score: " + score.ToString();
        if (countBricks == 0)
        {
        //    YouWon.text = "YOU WON!";

            // ScriptB
            CallScript.LevelComplete();
                                 
        }
    }

}
