using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPowerUp : MonoBehaviour
{

    float tiempoSpawn;
    public GameObject powerUp;
    private GameObject clon;
    public float velocidad;


    public GameObject A;
    public GameObject B;

    //Banderas

    private bool movA = false;
    private bool movB = false;


    // Use this for initialization
    void Start()
    {
        transform.position = A.transform.position;
        tiempoSpawn = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoSpawn = tiempoSpawn - Time.deltaTime;

        if (tiempoSpawn <= 0)
        {
            clon = Instantiate(powerUp, gameObject.transform.position, Quaternion.identity);
            tiempoSpawn = 10f;
            Debug.Log("Power up spawneado en: " + clon.transform.position);

        }


        if (transform.position == A.transform.position)
        {
            movB = true;
            movA = false;
            
        }

        if(movB)
        {
            transform.position = Vector3.MoveTowards(transform.position, B.transform.position, velocidad * Time.deltaTime);
        }

        if (transform.position == B.transform.position)
        {
            movA = true;
            movB = false;

        }
        if (movA)
        {
            transform.position = Vector3.MoveTowards(transform.position, A.transform.position, velocidad * Time.deltaTime);
        }

    }
}

