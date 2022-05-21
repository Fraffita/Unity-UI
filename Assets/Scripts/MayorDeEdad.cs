using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayorDeEdad : MonoBehaviour
{
    public int edadUsuario;
    public Text texto;

    void Start()
    {
       if (edadUsuario >= 18)
        {
            texto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        } 

       else
        {
            texto.text = "No es mayor de edad";
            Debug.Log("No es mayor de edad");
        }
    }

   
}
