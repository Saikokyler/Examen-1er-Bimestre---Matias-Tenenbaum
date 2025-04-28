using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaTaxis : MonoBehaviour
{
    public int cantidadDeUnidades;
    int unidadTaxi;
    float distanciaRecorridaPorDia;
    public int periodoDeDias;
    float costoTotalCombustible;
    float litroDeCombustible;
    int kilometro;



    // Start is called before the first frame update
    void Start()
    {
        distanciaRecorridaPorDia = cantidadDeUnidades * 90 ;
        distanciaRecorridaPorDia = distanciaRecorridaPorDia * periodoDeDias;
        litroDeCombustible = distanciaRecorridaPorDia / 15; 
        costoTotalCombustible = litroDeCombustible * 130  ;
        


        if (periodoDeDias < 5 )
        {
            Debug.Log("Error, el periodo de dias debe ser mayor a 5 para calcularlo, intente otra vez!");
            return; 
        }

        if (cantidadDeUnidades < 1)
        {
            Debug.Log("Error, la cantidad de unidades es menor a 1, intente otra vez!");
            return;
        }

        if (litroDeCombustible >= 100)
        {
            costoTotalCombustible = costoTotalCombustible - (costoTotalCombustible / 100) * 20 ;
        }
        
        




        Debug.Log($"Una flota de {cantidadDeUnidades} unidades trabajando durante {periodoDeDias} días implicará un gasto de {costoTotalCombustible} pesos en concepto de combustible");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
