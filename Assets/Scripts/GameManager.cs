using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public event Action OnMainMenuLogo;
    public event Action OnMainMenu;
    public event Action OnItemsMenu;
    public event Action OnARPosition;
    public event Action OnPitagoras;
    public event Action OnPitagorasCalc;
    public event Action OnSombreado;
    public event Action OnSombreadoCalc;
    public event Action OnMenuCalculadoras;
    public event Action OnAngulo;
    public event Action OnAnguloCalc;
    public event Action OnTrianguloLad;
    public event Action OnTrianguloAng;
    public event Action OnTrianguloCalc;


    public static GameManager instance;
    private void Awake()
    {
        if (instance!=null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        MainMenuLogo();
        MainMenuLogo();
    }

    public void MainMenuLogo()
    {
        OnMainMenuLogo?.Invoke();
        Debug.Log("Menu Inicial Activated");
    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Main Menu Activated");
    }

    public void ItemMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Items Menu Activated");
    }

    public void ARPosition() 
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position Activated");
    }

    public void Pitagoras()
    {
        OnPitagoras?.Invoke();
        Debug.Log("Msg Pitagoras");
    }

    public void PitagorasCalc()
    {
        OnPitagorasCalc?.Invoke();
        Debug.Log("Msg Calc Pitagoras");
    }

    public void CloseAPP()
    {
        Application.Quit();
    }

    public void MenuCalc()
    {
        OnMenuCalculadoras?.Invoke();
        Debug.Log("Msg Menu Calc");
    }

    public void Sombreado()
    {
        OnSombreado?.Invoke();
        Debug.Log("Msg AreaSombreado");
    }

    public void SombreadoCalc()
    {
        OnSombreadoCalc?.Invoke();
        Debug.Log("Msg Calc AreaSombreado");
    }

    public void Angulo()
    {
        OnAngulo?.Invoke();
        Debug.Log("Msg Angulo");
    }

    public void AnguloCalc()
    {
        OnAnguloCalc?.Invoke();
        Debug.Log("Msg Calc Total Angulo");
    }

    public void TrianguloLAD()
    {
        OnTrianguloLad?.Invoke();
        Debug.Log("Msg Angulo");
    }

    public void TrianguloANG()
    {
        OnTrianguloAng?.Invoke();
        Debug.Log("Msg Angulo");
    }

    public void TrianguloCalc()
    {
        OnTrianguloCalc?.Invoke();
        Debug.Log("Msg Calc Total Angulo");
    }

}
