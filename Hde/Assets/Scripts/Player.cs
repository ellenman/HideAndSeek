using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public float speed;
    public AudioClip enemySound;
    public AudioClip fallSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //move forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + transform.forward, speed * Time.deltaTime);

        }


        //move backwards
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - transform.forward, speed * Time.deltaTime);

        }


        //move right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + transform.right, speed * Time.deltaTime);

        }


        //move left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - transform.right, speed * Time.deltaTime);

        }


        if(gameObject.transform.position.y < -1f)
        {
            AudioSource.PlayClipAtPoint(fallSound, transform.position);
            FindObjectOfType<GameManager>().EndGame();
        }
    }



    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Enemy") 
        {
            gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(enemySound,transform.position);

            FindObjectOfType<GameManager>().EndGame();
            
            
        }
    }






}

