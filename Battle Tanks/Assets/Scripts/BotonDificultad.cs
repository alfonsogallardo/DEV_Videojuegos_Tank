using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonDificultad : MonoBehaviour
{
    public int dificultad;
    private Button boton;

    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(establecerDificultad);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void establecerDificultad() 
    {
        if (dificultad == 1)
        {
            VEne1.vidas1 = 1;
            VEne2.vidas2 = 1;
            VEne3.vidas3 = 1;
            VEne4.vidas4 = 1;
            VEne5.vidas5 = 1;
        }
        else if (dificultad == 2)
        {
            VEne1.vidas1 = 3;
            VEne2.vidas2 = 3;
            VEne3.vidas3 = 3;
            VEne4.vidas4 = 3;
            VEne5.vidas5 = 3;
        }
        else if (dificultad == 3)
        {
            VEne1.vidas1 = 5;
            VEne2.vidas2 = 5;
            VEne3.vidas3 = 5;
            VEne4.vidas4 = 5;
            VEne5.vidas5 = 5;
        } 

        SceneManager.LoadScene("EscenaJuego");
    } 
}
