using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemymovement : MonoBehaviour
{

    NavMeshAgent enemy;
    public Animator manimator;
    GameObject player;
    public float timer;
    public int multipler = 2;
    public bool walking = true;

    private float speed;


    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
        manimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        speed = enemy.speed;
        enemy.SetDestination(player.transform.position);
        timer += Time.deltaTime * multipler;

        if (walking == true)
        {
            timer += Time.deltaTime * multipler;

        }

        if (timer >= 2)
        {
            manimator.SetFloat("walkingspeed", speed);

            walking = false;
        }

        if (timer >= 10)
        {
            enemy.speed =2;
        }
        if (timer >= 20)
        {
            enemy.speed = 3;
        }
        if (timer >= 25)
        {
            enemy.speed = 4;

        }
        if (timer >= 40)
        {
            enemy.speed = 7;
            
        }
        if (timer >= 55)
        {
            enemy.speed = 11;
            timer = 55;
            multipler = 0;
        }
    }



}
