//Realizá un programa donde se cree una variable entera llamada num1, que inicialmente
//valdrá 0. Luego incrementá su valor en 2 y mostralo por pantalla. Después mostrá el
//resultado de multiplicarlo por sí mismo.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num1;
        num1 = 0;
        num1 += 2;
        Debug.Log("El resultado es: " + num1);
        Debug.Log("El otro resultado es: " + num1 * num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
