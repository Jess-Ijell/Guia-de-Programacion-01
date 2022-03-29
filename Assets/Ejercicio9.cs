//Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre:... capital aportado: $... , Porcentaje del capital: %... , Monto total aportado: $....


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    int aporte1 = 1;
    int aporte2 = 2;
    int aporte3 = 3;

    // Start is called before the first frame update
    void Start()
    {
        int sumaaportes = aporte1 + aporte2 + aporte3;
        int porcentaje1 = aporte1 * 100 / sumaaportes;
        int porcentaje2 = aporte2 * 100 / sumaaportes;
        int porcentaje3 = aporte3 * 100 / sumaaportes;

        Debug.Log("PERSONA 1: capital aportado: " + aporte1 + ", porcentaje del acpital: " + porcentaje1 + "%, monto total aportado: $" + sumaaportes);
        Debug.Log("PERSONA 2: capital aportado: " + aporte2 + ", porcentaje del acpital: " + porcentaje2 + "%, monto total aportado: $" + sumaaportes);
        Debug.Log("PERSONA 3: capital aportado: " + aporte3 + ", porcentaje del acpital: " + porcentaje3 + "%, monto total aportado: $" + sumaaportes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
