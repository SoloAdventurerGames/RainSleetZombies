using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementWASD : MonoBehaviour
{
    private Rigidbody player;
    public float speed = 3;
    public GameObject playermodel;

    public bool hammerpickedup = false;

    public GameObject hammerback;
    public GameObject hammerhand;
    public GameObject hammerCol;

    public GameObject baghand;
    public GameObject bagshoulder;
    public GameObject bagcol;

   

    float move;

    private Animator manimator;
    private void Start()
    {
        player = GetComponent<Rigidbody>();
        manimator = GetComponent<Animator>();
    }
    void Update()
    {

     
      

        if (Input.GetKey(KeyCode.W))
        {
            
            player.velocity = transform.forward;
            player.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            playermodel.transform.rotation = Quaternion.Euler(-90, 180, 0);
            

        }



        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(Vector3.back * Time.deltaTime * speed);
            player.velocity = transform.forward;
            
            playermodel.transform.rotation = Quaternion.Euler(-90, 0, 0);
            
        }
     

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(Vector3.left * Time.deltaTime * speed);
            playermodel.transform.rotation = Quaternion.Euler(-90, 90, 0);
            player.velocity = transform.forward;
            
        }


        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(Vector3.right * Time.deltaTime * speed);
            playermodel.transform.rotation = Quaternion.Euler(-90, -90, 0);
            player.velocity = transform.forward;
            
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 5;
            
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 3;

        }


        if (Input.GetMouseButtonDown(0))
        {
            manimator.SetTrigger("Attack");
           
            hammerhand.SetActive(false);
            baghand.SetActive(true);
            bagshoulder.SetActive(false);
            bagcol.SetActive(true);
            hammerCol.SetActive(false);
            if (hammerpickedup == true)
            {
                hammerback.SetActive(false);
            }
            
        }
        if (hammerpickedup == true)
        {
            if (Input.GetMouseButtonDown(1))
            {

                hammerback.SetActive(false);
                hammerhand.SetActive(true);
                baghand.SetActive(false);
                bagshoulder.SetActive(true);
                manimator.SetTrigger("heavyattack");
                bagcol.SetActive(false);
                hammerCol.SetActive(true);
            }
        }
  
        
    }
    private void FixedUpdate()
    {
        manimator.SetFloat("walkingspeed", player.velocity.magnitude * speed);
    }

   

}