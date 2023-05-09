using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissedScript : MonoBehaviour
{

    public Text Missed;

    // Start is called before the first frame update
    void Start()
    {
        Missed = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Missed.text = ("Missed: " + GameManager.instance.missed);
    }
}
