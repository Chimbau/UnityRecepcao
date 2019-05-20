using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDialog : MonoBehaviour
{
    public GameObject CloseMessage;
    //public GameObject Object;
    public Dialog dialog;
    public AudioSource TelefoneTocando;
    //public AudioSource Music;
   
    private bool tocando;

    void Start()
    {
        tocando = false;
        StartCoroutine(TempoInical());
        
    }

    IEnumerator TempoInical()
    {
        
        yield return new WaitForSeconds(5);
        tocando = true;
        GetComponent<Animator>().SetBool("Tocando", true);
        TelefoneTocando.Play();

    }


    public void ShowCloseMessage()
    {
        if (tocando)
        {
            CloseMessage.SetActive(true);
        }
        
    
    }

    public void HideCloseMessage()
    {
        CloseMessage.SetActive(false);
    }

    public void ShowObject()
    {
        tocando = false;
        GetComponent<Animator>().SetBool("Tocando", false);
        TelefoneTocando.Stop();

        dialog.StartDialog();
      

    }


    public bool EstaTocando()
    {
        return tocando;
    }


}
