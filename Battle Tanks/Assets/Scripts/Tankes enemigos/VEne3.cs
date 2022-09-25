using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEne3 : MonoBehaviour
{
    public static float vidas3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tengo   " + vidas3);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            vidas3 = vidas3 - 1;
            Destroy(collision.gameObject);

            if (vidas3 <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
