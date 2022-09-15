using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This will make the cube rotate while the game is running 
public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3 (13, 30, 45) * Time.deltaTime);
    }
}
