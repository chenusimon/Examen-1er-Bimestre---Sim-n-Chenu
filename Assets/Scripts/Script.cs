using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public float horasXSemana;
    public string claseEntrenamiento;
    float PrecioCardio = 1000f;
    float PrecioRecreativo = 2500f;
    float PrecioFuerza = 1500f;
    int horasMax = 6;
    float result;
    float resultD;

    // Start is called before the first frame update
    void Start()
    {
        if (horasXSemana > horasMax)
        {
            Debug.Log("cantidad de horas demasiado grande, maximo " + horasMax + ".");
        }else if (horasXSemana < 0)
        {
            Debug.Log("Cantidad de horas demasiado chica, debe ser mayor a 0.");
        }else if (claseEntrenamiento == "cardio")
        {
            result = horasXSemana * PrecioCardio;

            if (horasXSemana == horasMax)
            {
                resultD = result * 0.9f;
                Debug.Log("Tipo de entrenamiento = " + claseEntrenamiento + ". Horas reservadas = " + horasXSemana + ". Precio sin descuento = " + result + ". Precio con descuento = " + resultD);
            }else {
                Debug.Log("Tipo de entrenamiento = " + claseEntrenamiento + ". Horas reservadas = " + horasXSemana + ". Precio = " + result);
            }
        }
        else if (claseEntrenamiento == "fuerza")
        {
            result = horasXSemana * PrecioFuerza;

            if (horasXSemana == horasMax)
            {
                resultD = result * 0.9f;
                Debug.Log("Tipo de entrenamiento = " + claseEntrenamiento + ". Horas reservadas = " + horasXSemana + ". Precio sin descuento = " + result + ". Precio con descuento = " + resultD);
            }
            else
            {
                Debug.Log("Tipo de entrenamiento = " + claseEntrenamiento + ". Horas reservadas = " + horasXSemana + ". Precio = " + result);
            }
        }
        else if (claseEntrenamiento == "recreativo")
        {
            result = horasXSemana * PrecioRecreativo;

            if (horasXSemana == horasMax)
            {
                resultD = result * 0.9f;
                Debug.Log("Tipo de entrenamiento = " + claseEntrenamiento + ". Horas reservadas = " + horasXSemana + ". Precio sin descuento = " + result + ". Precio con descuento = " + resultD);
            }
            else
            {
                Debug.Log("Tipo de entrenamiento = " + claseEntrenamiento + ". Horas reservadas = " + horasXSemana + ". Precio = " + result);
            }
        }
        else
        {
            Debug.Log("La clase de entrenamiento es incorrecta, las opciones son fuerza, recreativo y cardio. Asegurese de no usar mayusculas");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
