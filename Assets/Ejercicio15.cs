//Existen dos reglas que identifican dos conjuntos de valores:
//- El número es de un solo dígito.
//- El número es impar.
//A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA,
//estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,
//para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a
//ninguno, respectivamente. Definí un lote de prueba de varios números y probá el algoritmo,
//escribiendo los resultados.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    public int numero;

    // Start is called before the first frame update
    void Start()
    {
        bool estaEnA;
        bool estaEnB;
        bool estaEnAmbos;
        bool noEstaEnNinguno;

        if (numero < 10 && numero > -10)
        {
            if (numero % 2 == 0)
            {
                estaEnAmbos = true;
                Debug.Log("El número " + numero + " pertenece a ambos conjuntos.");
            }

            else
            {
                estaEnA = true;
                Debug.Log("El número " + numero + " solo pertenece al primero conjunto (es de un solo dígito).");
            }
        }

        else
        {
            if (numero % 2 != 0)
            {
                estaEnB = true;

                Debug.Log("El número " + numero + " solo pertenece al segundo conjunto (es impar).");
            }

            else
            {
                noEstaEnNinguno = true;
                Debug.Log("El número " + numero + " no pertenece a ningún conjunto.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
