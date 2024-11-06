using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class ARInteractionsManager : MonoBehaviour
{
    [SerializeField] private Camera aRCamera;
    private ARRaycastManager aRRaycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private GameObject aRPointer;
    private GameObject item3DModel;
    private GameObject itemSelected;

    private bool isInitialPosition;
    private bool isOverUI;
    private bool isOver3DModel;
    private bool isOver3DModelPIT;
    private bool isOver3DModelSOM;
    private bool isOver3DModelANG;
    private bool isOver3DModelTL;
    private bool isOver3DModelTA;

    private Vector2 initialTouchPos;

    public Text Text;
    private int ValorX = 4;
    private int ValorY = 4;

    public GameObject Item3DModel
    {
        set
        {
            item3DModel = value;
            item3DModel.transform.position = aRPointer.transform.position;
            item3DModel.transform.parent = aRPointer.transform;
            isInitialPosition = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        aRPointer = transform.GetChild(0).gameObject;
        aRRaycastManager = FindObjectOfType<ARRaycastManager>();
        GameManager.instance.OnMainMenu += SetItemPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInitialPosition)
        {
            Vector2 middlePointScreen = new Vector2(Screen.width / 2, Screen.height / 2);
            aRRaycastManager.Raycast(middlePointScreen, hits, TrackableType.Planes);
            if (hits.Count > 0)
            {
                transform.position = hits[0].pose.position;
                transform.rotation = hits[0].pose.rotation;
                aRPointer.SetActive(true);
                isInitialPosition = false;
            }
        }

        if (Input.touchCount > 0)
        {
            Touch touchOne = Input.GetTouch(0);
            if (touchOne.phase == TouchPhase.Began)
            {
                var touchPosition = touchOne.position;
                isOverUI = isTapOverUI(touchPosition);
                isOver3DModel = isTapOver3DModel(touchPosition);
                isOver3DModelPIT = isTapOver3DModelPIT(touchPosition);
                isOver3DModelSOM = isTapOver3DModelSOM(touchPosition);
                isOver3DModelANG = isTapOver3DModelANG(touchPosition);
                isOver3DModelTL = isTapOver3DModelTL(touchPosition);
                isOver3DModelTA = isTapOver3DModelTA(touchPosition);
            }

            if (touchOne.phase == TouchPhase.Moved)
            {
                if (aRRaycastManager.Raycast(touchOne.position, hits, TrackableType.Planes))
                {
                    Pose hitPose = hits[0].pose;
                    if (!isOverUI && isOver3DModel)
                    {
                        transform.position = hitPose.position;
                    }
                }
                if (aRRaycastManager.Raycast(touchOne.position, hits, TrackableType.Planes))
                {
                    Pose hitPose = hits[0].pose;
                    if (!isOverUI && isOver3DModelPIT)
                    {
                        transform.position = hitPose.position;
                    }
                }
                if (aRRaycastManager.Raycast(touchOne.position, hits, TrackableType.Planes))
                {
                    Pose hitPose = hits[0].pose;
                    if (!isOverUI && isOver3DModelSOM)
                    {
                        transform.position = hitPose.position;
                    }
                }
                if (aRRaycastManager.Raycast(touchOne.position, hits, TrackableType.Planes))
                {
                    Pose hitPose = hits[0].pose;
                    if (!isOverUI && isOver3DModelANG)
                    {
                        transform.position = hitPose.position;
                    }
                }
                if (aRRaycastManager.Raycast(touchOne.position, hits, TrackableType.Planes))
                {
                    Pose hitPose = hits[0].pose;
                    if (!isOverUI && isOver3DModelTL)
                    {
                        transform.position = hitPose.position;
                    }
                }
                if (aRRaycastManager.Raycast(touchOne.position, hits, TrackableType.Planes))
                {
                    Pose hitPose = hits[0].pose;
                    if (!isOverUI && isOver3DModelTA)
                    {
                        transform.position = hitPose.position;
                    }
                }
            }

            if (Input.touchCount == 2)
            {
                Touch touchTwo = Input.GetTouch(1);
                if (touchOne.phase == TouchPhase.Began || touchTwo.phase == TouchPhase.Began)
                {
                    initialTouchPos = touchTwo.position - touchOne.position;
                }

                if (touchOne.phase == TouchPhase.Moved || touchTwo.phase == TouchPhase.Moved)
                {
                    Vector2 currentTouchPos = touchTwo.position - touchOne.position;
                    float angle = Vector2.SignedAngle(initialTouchPos, currentTouchPos);
                    item3DModel.transform.rotation = Quaternion.Euler(0, item3DModel.transform.eulerAngles.y - angle, 0);
                    initialTouchPos = currentTouchPos;
                }
            }

            if (isOver3DModel && item3DModel == null && Input.touchCount == 1)
            {
                GameManager.instance.ARPosition();
                item3DModel = itemSelected;
                itemSelected = null;
                aRPointer.SetActive(true);
                transform.position = item3DModel.transform.position;
                item3DModel.transform.parent = aRPointer.transform;
            }

            if (isOver3DModelPIT && item3DModel == null && Input.touchCount == 1)
            {
                GameManager.instance.Pitagoras();
                item3DModel = itemSelected;
                itemSelected = null;
                aRPointer.SetActive(true);
                transform.position = item3DModel.transform.position;
                item3DModel.transform.parent = aRPointer.transform;
            }

            if (isOver3DModelSOM && item3DModel == null && Input.touchCount == 1)
            {
                GameManager.instance.Sombreado();
                item3DModel = itemSelected;
                itemSelected = null;
                aRPointer.SetActive(true);
                transform.position = item3DModel.transform.position;
                item3DModel.transform.parent = aRPointer.transform;
            }

            if (isOver3DModelANG && item3DModel == null && Input.touchCount == 1)
            {
                GameManager.instance.Angulo();
                item3DModel = itemSelected;
                itemSelected = null;
                aRPointer.SetActive(true);
                transform.position = item3DModel.transform.position;
                item3DModel.transform.parent = aRPointer.transform;
            }

            if (isOver3DModelTL && item3DModel == null && Input.touchCount == 1)
            {
                GameManager.instance.TrianguloLAD();
                item3DModel = itemSelected;
                itemSelected = null;
                aRPointer.SetActive(true);
                transform.position = item3DModel.transform.position;
                item3DModel.transform.parent = aRPointer.transform;
            }

            if (isOver3DModelTA && item3DModel == null && Input.touchCount == 1)
            {
                GameManager.instance.TrianguloANG();
                item3DModel = itemSelected;
                itemSelected = null;
                aRPointer.SetActive(true);
                transform.position = item3DModel.transform.position;
                item3DModel.transform.parent = aRPointer.transform;
            }
        }
    }

    private bool isTapOver3DModel(Vector2 touchPosition)
    {
        Ray ray = aRCamera.ScreenPointToRay(touchPosition);
        if (Physics.Raycast(ray, out RaycastHit hit3DModel))
        {
            if (hit3DModel.collider.CompareTag("Item"))
            {
                itemSelected = hit3DModel.transform.gameObject;
                return true;
            }
        }

        return false;
    }

    private bool isTapOver3DModelPIT(Vector2 touchPosition)
    {
        Ray ray = aRCamera.ScreenPointToRay(touchPosition);
        if (Physics.Raycast(ray, out RaycastHit hit3DModel))
        {

            if (hit3DModel.collider.CompareTag("Pitagoras"))
            {
                itemSelected = hit3DModel.transform.gameObject;
                return true;
            }
        }

        return false;
    }

    private bool isTapOver3DModelSOM(Vector2 touchPosition)
    {
        Ray ray = aRCamera.ScreenPointToRay(touchPosition);
        if (Physics.Raycast(ray, out RaycastHit hit3DModel))
        {

            if (hit3DModel.collider.CompareTag("Sombreado"))
            {
                itemSelected = hit3DModel.transform.gameObject;
                return true;
            }
        }

        return false;
    }

    private bool isTapOver3DModelANG(Vector2 touchPosition)
    {
        Ray ray = aRCamera.ScreenPointToRay(touchPosition);
        if (Physics.Raycast(ray, out RaycastHit hit3DModel))
        {

            if (hit3DModel.collider.CompareTag("Angulos"))
            {
                itemSelected = hit3DModel.transform.gameObject;
                return true;
            }
        }

        return false;
    }

    private bool isTapOver3DModelTL(Vector2 touchPosition)
    {
        Ray ray = aRCamera.ScreenPointToRay(touchPosition);
        if (Physics.Raycast(ray, out RaycastHit hit3DModel))
        {

            if (hit3DModel.collider.CompareTag("TrianguloL"))
            {
                itemSelected = hit3DModel.transform.gameObject;
                return true;
            }
        }

        return false;
    }

    private bool isTapOver3DModelTA(Vector2 touchPosition)
    {
        Ray ray = aRCamera.ScreenPointToRay(touchPosition);
        if (Physics.Raycast(ray, out RaycastHit hit3DModel))
        {

            if (hit3DModel.collider.CompareTag("TrianguloA"))
            {
                itemSelected = hit3DModel.transform.gameObject;
                return true;
            }
        }

        return false;
    }

    private bool isTapOverUI(Vector2 touchPosition)
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = new Vector2(touchPosition.x, touchPosition.y);

        List<RaycastResult> result = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, result);

        return result.Count > 0;
    }

    private void SetItemPosition()
    {
        if (item3DModel != null)
        {
            item3DModel.transform.parent = null;
            aRPointer.SetActive(false);
            item3DModel = null;
        }

    }

    public void DeleteItem()
    {
        Destroy(item3DModel);
        aRPointer.SetActive(false);
        GameManager.instance.MainMenu();
    }

    public void MasGrandeX()
    {
        Vector3 scaleChange = new Vector3(0.01f, 1, 1);
        item3DModel.transform.localScale += scaleChange;
    }

    public void MasGrandeZ()
    {
        Vector3 scaleChange = new Vector3(1, 1, 0.01f);
        item3DModel.transform.localScale += scaleChange;
    }

    public void MasGrandeY()
    {
        Vector3 scaleChange = new Vector3(1, 0.01f, 1);
        item3DModel.transform.localScale += scaleChange;
    }

    public void CambiarX()
    {
        ValorX = ValorX + 1;
        string X1 = "X: "+ValorX+"  ,Y: "+ValorY;
        Text.text = X1;
    }

    public void CambiarY()
    {
        ValorY = ValorY + 1;
        string X1 = "X: " + ValorX + "  ,Y: " + ValorY;
        Text.text = X1;
    }
}
