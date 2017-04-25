using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject Left;
    public GameObject Right;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Update")
        {
            float tmp = Random.Range(0, 2);

            if (tmp < 1)
            {
                Left.SetActive(false);
                Right.SetActive(true);
            }
            else
            {
                Left.SetActive(true);
                Right.SetActive(false);
            }
            
        }  
    }
}
