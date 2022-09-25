using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEne5 : MonoBehaviour
{
    public static float vidas5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tengo   " + vidas5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            vidas5 = vidas5 - 1;
            Destroy(collision.gameObject);

            if (vidas5 <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
