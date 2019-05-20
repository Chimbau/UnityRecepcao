using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSound : MonoBehaviour
{

    public GameObject CloseMessage;
    public AudioSource somSino;

    void Start()
    {
        somSino = GetComponent<AudioSource>();
       



    }


    public void ShowCloseMessage()
    {
        //CloseMessage.SetActive(true);
    }

    public void HideCloseMessage()
    {
       // CloseMessage.SetActive(false);
    }

    public void PlaySino()
    {
        somSino.Play();
    }
}
