using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MenuInicial;
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject itemMenuCanvas;
    [SerializeField] private GameObject ARPositionCanvas;

    [SerializeField] private GameObject PitagorasMsg;
    [SerializeField] private GameObject PitagorasCalc;

    [SerializeField] private GameObject SombreadoMsg;
    [SerializeField] private GameObject SombreadoCalc;

    [SerializeField] private GameObject MenuCalc;

    [SerializeField] private GameObject AnguloMsg;
    [SerializeField] private GameObject AnguloCalc;

    [SerializeField] private GameObject TrianguloLadMsg;
    [SerializeField] private GameObject TrianguloAngMsg;
    [SerializeField] private GameObject TrianguloCalc;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnMainMenuLogo += ActivarMenuInicial;
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnItemsMenu += ActivateItemsMenu;
        GameManager.instance.OnARPosition += ActivateARPosition;

        GameManager.instance.OnPitagoras += ActivatePitagoras;
        GameManager.instance.OnPitagorasCalc += ActivatePitagorasCalc;

        GameManager.instance.OnSombreado += ActivateSombreado;
        GameManager.instance.OnSombreadoCalc += ActivateSombreadoCalc;

        GameManager.instance.OnMenuCalculadoras += ActivateMenuCalc;

        GameManager.instance.OnAngulo += ActivateAngulo;
        GameManager.instance.OnAnguloCalc += ActivateAnguloCalc;

        GameManager.instance.OnTrianguloLad += ActivateTrianguloLad;
        GameManager.instance.OnTrianguloAng += ActivateTrianguloAng;
        GameManager.instance.OnTrianguloCalc += ActivateTrianguloCalc;
    }

    private void ActivarMenuInicial()
    {
        MenuInicial.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MenuInicial.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MenuInicial.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MenuInicial.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MenuInicial.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        PitagorasMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        PitagorasCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloLadMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloAngMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivateMainMenu()
    {
        MenuInicial.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        PitagorasMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        PitagorasCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        SombreadoMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        SombreadoCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloLadMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloAngMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivateItemsMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);

        PitagorasMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        PitagorasCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        SombreadoMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        SombreadoCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloLadMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloAngMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivateARPosition()
    {
        MenuInicial.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        PitagorasMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        PitagorasCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        SombreadoMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        SombreadoCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloLadMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloAngMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivatePitagoras()
    {
        MenuInicial.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        PitagorasMsg.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        PitagorasMsg.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        PitagorasMsg.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        SombreadoMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloLadMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloAngMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivatePitagorasCalc()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        PitagorasCalc.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        PitagorasCalc.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        PitagorasCalc.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        SombreadoCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivateSombreado()
    {
        MenuInicial.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        PitagorasMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        SombreadoMsg.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        SombreadoMsg.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        SombreadoMsg.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        AnguloMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloLadMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloAngMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivateSombreadoCalc()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        SombreadoCalc.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        SombreadoCalc.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        SombreadoCalc.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        PitagorasCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivateMenuCalc()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        PitagorasMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        PitagorasCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
    }

    private void ActivateAngulo()
    {
        MenuInicial.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        PitagorasMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        SombreadoMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloMsg.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        AnguloMsg.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        AnguloMsg.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        TrianguloLadMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloAngMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivateAnguloCalc()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        SombreadoCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        PitagorasCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        AnguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        AnguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        AnguloCalc.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        TrianguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivateTrianguloLad()
    {
        MenuInicial.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        PitagorasMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        SombreadoMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloLadMsg.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        TrianguloLadMsg.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        TrianguloLadMsg.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        TrianguloAngMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloAngMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivateTrianguloAng()
    {
        MenuInicial.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuInicial.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        PitagorasMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        SombreadoMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloLadMsg.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        TrianguloLadMsg.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloAngMsg.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        TrianguloAngMsg.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        TrianguloAngMsg.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

    private void ActivateTrianguloCalc()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        SombreadoCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        SombreadoCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        PitagorasCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        PitagorasCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        AnguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        AnguloCalc.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        TrianguloCalc.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        TrianguloCalc.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        TrianguloCalc.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        MenuCalc.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        MenuCalc.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MenuCalc.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
    }

}
