using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClasifTriangulo : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Text componenteClasif = null;
    [SerializeField]
    private UnityEngine.UI.Text componenteTexto = null; //Esta es la referencia del componente Text en donde hay que mostrar el resultado

    private string Modo = null;
    private string Clasific;
    private string Valor1;
    private string Valor2;
    private string Valor3;
    private int Clasif = 0;


    public void IngresarClasif()
    {
        Clasif = Clasif + 1;

        if (Clasif == 1)
        {
            Modo = "LADOS";
        }
        else if (Clasif == 2)
        {
            Modo = "ANGULOS";
            Clasif = 0;
        }

        componenteClasif.text = Modo.ToString();
        Debug.Log("Dato Figura asignado");
    }

    public void IngresarDato1(string s)
    {

        Valor1 = s;
        Debug.Log("Dato 1 asignado");
    }

    public void IngresarDato2(string s)
    {
        Valor2 = s;
        Debug.Log("Dato 2 asignado");
    }

    public void IngresarDato3(string s)
    {
        Valor3 = s;
        Debug.Log("Dato 3 asignado");
    }

    public void AlgoritmoEjercicio()
    {
        float c;
        float v1 = float.Parse(Valor1);
        float v2 = float.Parse(Valor2);
        float v3 = float.Parse(Valor3);

        c = v1 + v2 + v3;

        if (Modo.Equals("LADOS"))
        {

            if (((v1 == v2) && (v1 != v3)) || ((v2 == v3) && (v2 != v3)) || ((v3 == v1) && (v3 != v2)))
            {
                Clasific = "ISOCELES";
            }

            if ((v1 != v2) && (v1 != v3) && (v2 != v3))
            {
                Clasific = "ESCALENO";
            }

            if ((v1 == v2) && (v1 == v3) && (v3 == v2))
            {
                Clasific = "EQUILATERO";
            }
        }

        if (Modo.Equals("ANGULOS"))
        {
            if(c == 180)
            {

                if ((v1 > 0 && v1 < 90) && (v2 > 0 && v2 < 90) && (v2 > 0 && v2 < 90) )
                {
                    Clasific = "ACUTANGULO";
                }

                if (v1 == 90 || v2 == 90 || v3 == 90)
                {
                    Clasific = "RECTANGULO";
                }

                if ((v1 > 90 && v1 <= 178) || (v2 > 90 && v2 <= 178) || (v2 > 90 && v2 <= 178))
                {
                    Clasific = "OBSTANGULO";
                }

            } else { Clasific = "ERROR DATOS"; }
        }

        componenteTexto.text = Clasific + "";

        Debug.Log("Formula AREA SOMBREADO ejecutada");
    }
}
