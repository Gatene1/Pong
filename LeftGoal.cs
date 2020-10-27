using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftGoal : MonoBehaviour
{
    public Text leftScoreText;
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
            leftScoreText.text = Score.ToString();
            other.transform.position = Vector3.zero;
        }
    }
}
