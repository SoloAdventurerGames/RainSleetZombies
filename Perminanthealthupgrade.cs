using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perminanthealthupgrade : MonoBehaviour
{
    PlayerStats playstats;


    private void Start()
    {
        playstats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (playstats.playermax == 10)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                FindObjectOfType<AudioManager>().Play("Playermax");
                playstats.playermax = 15;
                playstats.playerhealth = 15;
                Destroy(gameObject);
            }
        }
        else if (playstats.playermax == 15)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                FindObjectOfType<AudioManager>().Play("Playermax");
                playstats.playermax = 20;
                playstats.playerhealth = 20;
                Destroy(gameObject);
            }
        }
        else if (playstats.playermax == 20)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                FindObjectOfType<AudioManager>().Play("Playermax");
                playstats.playermax = 25;
                playstats.playerhealth = 25;
                Destroy(gameObject); ;
            }
        }
    }
}
