using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEne2 : MonoBehaviour
{
    public static float vidas2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tengo   " + vidas2);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            vidas2 = vidas2 - 1;
            Destroy(collision.gameObject);

            if (vidas2 <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
