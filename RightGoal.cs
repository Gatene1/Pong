using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RightGoal : MonoBehaviour
{
    public Text myScoreText;
    private int Score = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.name == "Ball")
        {
            Score++;
            myScoreText.text = Score.ToString();
            other.transform.position = Vector3.zero;
            if (Score == 1)
            {
                SceneManager.LoadScene("Pong", LoadSceneMode.Single);
            }
        }
    }
}
