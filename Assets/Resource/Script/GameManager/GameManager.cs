using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GameManager : MonoBehaviour
{
    //InteractUI
    [SerializeField] private GameObject UI;
    [SerializeField] private SteamVR_Action_Boolean InteractUI;

    void Start()
    {
        
    }


    void Update()
    {
        PressDownUI();
    }

    //ui ��ư �������� �ѹ��� ����
    private void PressDownUI()
    {
        if(InteractUI.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            Debug.Log("U Pres UI");

            if(UI.activeSelf == false) 
                UI.SetActive(true);
            else 
                UI.SetActive(false);
        }
    }

}
