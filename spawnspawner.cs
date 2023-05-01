using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnspawner : MonoBehaviour
{
    EnemySpawn enmspawn;


    private void Start()
    {
        enmspawn = GetComponent<EnemySpawn>();
    }


    private void OnBecameVisible()
    {
        enmspawn.enabled = true;
    }
    private void OnBecameInvisible()
    {
        enmspawn.enabled = false;
    }
}
