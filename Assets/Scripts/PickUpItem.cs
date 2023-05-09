using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUpItem : MonoBehaviour
{

    


    public void OnCollisionEnter2D(Collision2D collision)
    {

        if(GameManager.instance.missed == 9)
        {
            GameManager.instance.missed = 0;

            GameManager.instance.score = 0;

            SceneManager.LoadScene("Scene 3");

        }


        else if(GameManager.instance.score == 9)
        {
            GameManager.instance.score = 0;

            GameManager.instance.missed = 0;

            SceneManager.LoadScene("Scene 2");

        }

        else if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.score++;

            Destroy(gameObject);
        }

        else 
        {
            GameManager.instance.missed++;

            Destroy(gameObject);

        }

       

    }

   

   


}
