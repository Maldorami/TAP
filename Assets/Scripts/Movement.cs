using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {	

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.instance.CambiarLado();
        }       
	}

    void SumarPuntos()
    {
        GameManager.instance.SumarPuntos();
    }
}
