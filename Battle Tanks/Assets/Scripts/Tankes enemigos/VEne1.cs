using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEne1 : MonoBehaviour
{
    public static float vidas1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tengo   " + vidas1);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            vidas1 = vidas1 - 1;
            Destroy(collision.gameObject);

            if (vidas1 <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
