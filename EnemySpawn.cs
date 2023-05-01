using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float timer;
    public int multipler;
    Transform spawner;

    public GameObject Enemy;


    private void Start()
    {
        spawner = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * multipler;

        if (timer >= 25)
        {
            Instantiate(Enemy, spawner.position, spawner.rotation) ;
            timer = 0;
        }

       
    }
}
