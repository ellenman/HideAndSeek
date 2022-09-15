using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player2 : MonoBehaviour
{
    public float speed;

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


        if (gameObject.transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("AA");

        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Enemy1")
        {
            gameObject.SetActive(false);
            //call endgame from game manager
            Debug.Log("AA");
            FindObjectOfType<GameManager>().EndGame();


        }
    }






}

