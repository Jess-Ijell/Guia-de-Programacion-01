//Realizá un programa que resuelva el siguiente problema:
//Deberá ingresarse por Inspector una fecha de compra (String en el siguiente formato: YYYYMMDD),
//un nombre de comprador, un nombre de producto y una cantidad y precio del producto comprado.
//Mostrá a modo de ticket, la información ingresada y el monto a pagar.
//Modelo de Ticket:
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{

    public string fecha;
    public string nombre_comprador;
    public string producto;
    public int cantidad;
    public int precio;

    // Start is called before the first frame update
    void Start()
    {
        int total = cantidad * precio;
        Debug.Log("Fecha de compra: " + fecha + "\nNombre del comprador: " + nombre_comprador + "\nProducto solicitado: " + producto + "\nCantidad solicitada: " + cantidad + "\nPrecio unitario: " + precio + "\nTotal a pagar:" + total);       
    }
}
