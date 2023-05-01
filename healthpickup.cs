using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpickup : MonoBehaviour
{
    PlayerStats playstats;

    public GameObject parent;

    private void Start()
    {
        playstats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }
    private void OnTriggerEnter(Collider other)
    {
       
            if (other.gameObject.CompareTag("Player"))
            {
            if (playstats.playermax == 10)
            {
                FindObjectOfType<AudioManager>().Play("PlayerHeal");
                playstats.playerhealth = 10;
                Destroy(parent);
            }
            }
        

      
            if (other.gameObject.CompareTag("Player"))
            {
            if (playstats.playermax >= 15)
            {
                FindObjectOfType<AudioManager>().Play("PlayerHeal");
                playstats.playerhealth = 15;
                Destroy(parent);
            }
            } 

        
            if (other.gameObject.CompareTag("Player"))
            {
                if (playstats.playermax == 20)
                {
                    FindObjectOfType<AudioManager>().Play("PlayerHeal");
                playstats.playerhealth = 20;
                Destroy(parent);
            }
        }

      
            if (other.gameObject.CompareTag("Player"))
        {
            if (playstats.playermax == 25)
            {
                FindObjectOfType<AudioManager>().Play("PlayerHeal");
                playstats.playerhealth = 25;
                Destroy(parent);
            }
        }
    }
}
