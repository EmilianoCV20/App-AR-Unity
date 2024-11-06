using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angulos : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Text componenteTexto = null; //Esta es la referencia del componente Text en donde hay que mostrar el resultado

    private string AnguloA;
    private string AnguloB;
    private string TipoAng;

    public void IngresarDato1(string s)
    {

        AnguloA = s;
        Debug.Log("Dato 1 asignado");
    }

    public void IngresarDato2(string s)
    {
        AnguloB = s;
        Debug.Log("Dato 2 asignado");
    }

    public void Clasificacion(float c)
    {
        if (c == 0) { TipoAng = "Sin Angulo"; }
        if (c > 0 && c < 90) { TipoAng = "AGUDO"; }
        if (c == 90) { TipoAng = "RECTO"; }
        if (c > 90 && c < 180) { TipoAng = "OBTUSO"; }
        if (c == 180) { TipoAng = "LLANO"; }
        if (c > 180 && c < 270) { TipoAng = "CONCAVO"; }
        if (c == 270) { TipoAng = "RECTO"; }
        if (c > 270 && c < 360) { TipoAng = "CONCAVO"; }
        if (c == 360) { TipoAng = "COMPLETO"; }
    }

    public void AlgoritmoEjercicio()
    {
        float a = float.Parse(AnguloA);
        float b = float.Parse(AnguloB);

        float c = a + b;

        if (c > 360) { c -= 360; }

        while ( c > 360 )
        {
            c -= 360;
        }

        Clasificacion(c);

        componenteTexto.text = c.ToString() + "° (" + TipoAng + ")";

        Debug.Log("Suma de Angulo ejecutado!");
    }
}
