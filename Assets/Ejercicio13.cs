//Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:
//• Si trabaja 40 horas o menos se le paga $16 por hora (crear una constante para almacenar el 16)
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
//por cada hora extra. (crear una constante para almacenar el 20)
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
//el salario correspondiente.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    public int horas_trabajadas;

    // Start is called before the first frame update
    void Start()
    {
        int PagaPorHora = 16;
        int PagaHoraExtra = 20;
        int PagaTotal;

        if (horas_trabajadas <= 40)
        {
            PagaTotal = horas_trabajadas * PagaPorHora;
        }

        else
        {
            int PagaExtra = horas_trabajadas - 40;
            PagaTotal = 40 * PagaPorHora + PagaExtra * PagaHoraExtra;
        }

        Debug.Log("El salario corresponde a $" +PagaTotal);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
