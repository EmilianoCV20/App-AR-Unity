using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sombreado : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Text componenteFigura = null;
    [SerializeField]
    private UnityEngine.UI.Text componenteTexto = null; //Esta es la referencia del componente Text en donde hay que mostrar el resultado

    private string Figura = null;
    private string ValorF;
    private string ValorS;
    private int Fig;


    public void IngresarFigura()
    {
        Fig = Fig +1;

        if(Fig == 0) {
            Figura = "Figura";
        } else if (Fig == 1)
        {
            Figura = "Circulo";
        } else if (Fig == 2)
        {
            Figura = "Triangulo";
        } else if (Fig == 3)
        {
            Fig = 0;
            Figura = "Cuadrado";
        } else if (Fig == 4)
        {
            Fig = 0;
            Figura = "Figura1";
        }
        componenteFigura.text = Figura.ToString();
        Debug.Log("Dato Figura asignado");
    }

    public void IngresarDato1(string s)
    {

        ValorF = s;
        Debug.Log("Dato 1 asignado");
    }

    public void IngresarDato2(string s)
    {
        ValorS = s;
        Debug.Log("Dato 2 asignado");
    }

    public void AlgoritmoEjercicio()
    {
        float c = 0;
        float r = float.Parse(ValorF);
        float l = float.Parse(ValorS);

        if (Figura.Equals("Circulo")){
            c = (l * l) - (Mathf.PI * Mathf.Pow(r, 2));
        }

        if (Figura.Equals("Triangulo"))
        {
            c = (l * l) - ((r * r)/2);
        }

        if (Figura.Equals("Cuadrado"))
        {
            c = (l * l) - (r * r);
        }

        componenteTexto.text = c.ToString();

        Debug.Log("Formula AREA SOMBREADO ejecutada");
    }
}
