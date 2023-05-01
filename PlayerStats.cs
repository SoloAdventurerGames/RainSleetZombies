using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int playerhealth = 10;
    public int playermax = 10;
    public static int playerlives = 3;
    public int enemieskilled = 0;

    public TextMeshProUGUI health;
    public TextMeshProUGUI lives;
    public TextMeshProUGUI kills;



    public float timer;
    public int multipler;

    public bool timerstarted;

    void Start()
    {



    }

    private void Update()
    {
        if (playerhealth <= 0)
        {
            playerlives -= 1;
            SceneManager.LoadScene(1);
            timerstarted = false;
            Destroy(gameObject);

        }

        health.text = "Health:" + playerhealth.ToString();
        lives.text = "Lives:" + playerlives.ToString();
        kills.text = "Kills:" + enemieskilled.ToString();

        if (playerlives == 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerhealth -= 1;
            timerstarted = true;
            FindObjectOfType<AudioManager>().Play("PlayerHit");
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (timerstarted == true)
        {
            starttimer();
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (timer >= 5)

            {

                playerhealth -= 1;
                timer = 0;
                FindObjectOfType<AudioManager>().Play("PlayerHit");

            }
        }
    }


   

    private void OnCollisionExit(Collision collision)
    {
        stoptimer();
    }

    public void starttimer()
    {
        timer += Time.deltaTime * multipler;
    }

    public void stoptimer()
    {
        timer = 0;
        timerstarted = false;
    }
}
