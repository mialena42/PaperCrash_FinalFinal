using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionAsteroide : MonoBehaviour {

    public float velocidad;
   



	// Use this for initialization
	void Start () {

        velocidad = Random.Range(300f, 500f);
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(new Vector3(0, 0, Time.deltaTime * velocidad));
        Debug.Log("Soy " + gameObject.name + " y mi rotacion es: " + transform.rotation);

	}
}
