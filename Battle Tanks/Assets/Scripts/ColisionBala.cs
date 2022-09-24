using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBala : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 1.5f);
    }

    private void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name =="Paredes")
        {
            Destroy(gameObject);
        }
    }
}
