using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            GameManager.instance.PlayerLives--;
        }
    }

}
