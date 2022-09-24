using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBala : MonoBehaviour
{
    public int VidasBlinky = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Paredes" || collision.gameObject.name == "Blinky")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "Blinky")
        {
            VidasBlinky =VidasBlinky-1;

            if (VidasBlinky ==0)
            {
                Destroy(collision.gameObject);
            }           
            
        }
    }
}
