using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canpickup : MonoBehaviour
{
    Animator mAnimator;
    public GameObject Canisterspot;

    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {

            gameObject.transform.parent = Canisterspot.transform;
            gameObject.transform.position = Canisterspot.transform.position;
            gameObject.transform.rotation = Canisterspot.transform.rotation;
            gameObject.transform.localScale = Canisterspot.transform.localScale;
          
        }
    }
}
