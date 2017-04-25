using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public int Speed;

	void Start () {
        Speed = GameManager.instance.Velocity;
	}
	

	void Update () {
        Speed = GameManager.instance.Velocity;
        gameObject.transform.Rotate(Vector3.left * Speed * Time.deltaTime);
	}
}
