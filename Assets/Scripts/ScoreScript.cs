using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text Score;
    

    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text>();

       
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = ("Score: " + GameManager.instance.score);

        
    }

}   
