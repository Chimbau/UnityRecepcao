using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPanel : MonoBehaviour
{

    public GameObject CloseMessage;
    public GameObject Object;
    public GameObject Object2;


    void Awake()
    {
        
    }

    public void ShowCloseMessage()
    {
        if(CloseMessage != null)
        {
            CloseMessage.SetActive(true);
        }

       
    }

    public void HideCloseMessage()
    {
        if (CloseMessage != null)
        {
            CloseMessage.SetActive(false);
        }
    }

    public void ShowObject2(){
        if (Object2 != null){
            Object2.SetActive(true);
        }
        
    }

    public void ShowObject()
    {
        Object.SetActive(true);
    }

    public void HideObject()
    {
        Object.SetActive(false);

        if (Object2 != null){
            Object2.SetActive(false);
        }
        
    }
}
