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

    //ui 버튼 눌렀을때 한번만 실행
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
