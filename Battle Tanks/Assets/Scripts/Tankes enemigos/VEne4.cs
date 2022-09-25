using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEne4 : MonoBehaviour
{
    public static float vidas4;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tengo   " + vidas4);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            vidas4 = vidas4 - 1;
            Destroy(collision.gameObject);

            if (vidas4 <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
