using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{

    [SerializeField]
    private UnityEngine.UI.Text componenteTexto = null; //Esta es la referencia del componente Text en donde hay que mostrar el resultado

    private string catetoA;
    private string catetoB;

    public void IngresarDato1(string s)
    {

        catetoA = s;
        Debug.Log("Dato 1 asignado");
    }

    public void IngresarDato2(string s)
    {
        catetoB = s;
        Debug.Log("Dato 2 asignado");
    }

    public void AlgoritmoEjercicio()
    {
        float a = float.Parse(catetoA);
        float b = float.Parse(catetoB);
        //float c2 = a * a + b * b;

        float c2 = Mathf.Pow(a, 2) + Mathf.Pow(b, 2);

        float c = Mathf.Sqrt(c2);
        
        componenteTexto.text = c.ToString();

        Debug.Log("Formula PITAGORAS ejecutada!");
    }
}
