using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerpickup : MonoBehaviour
{
    public GameObject hammer;

    movementWASD playermovement;

    void Start()
    {
        playermovement = GameObject.FindGameObjectWithTag("Player").GetComponent<movementWASD>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("hammerpickup");
            playermovement.hammerpickedup = true;
            hammer.SetActive(true);
            Destroy(gameObject);
        }
    }
}
