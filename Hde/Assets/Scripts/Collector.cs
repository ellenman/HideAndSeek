using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collector : MonoBehaviour
{
    public AudioClip collectSound;
    public int count = 0;
    public Text scoreText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            scoreText.text = "Score: " + count;
            AudioSource.PlayClipAtPoint(collectSound, transform.position);

        }

        if (count == 10)
        {
            FindObjectOfType<GameManager>().CompleteLevel2();
        }



        
    }
}
