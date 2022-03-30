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
            estaEnA = true;

            if (numero % 2 == 0)
            {
                estaEnAmbos = true;
            }
        }

        else
        {
            if (numero % 2 == 0)
            {
                estaEnB = true;
            }

            else
            {
                noEstaEnNinguno = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
