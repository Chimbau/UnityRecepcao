using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCofre : MonoBehaviour
{


    private bool RemoveuQuadro = false;

    public GameObject KeyPad;
    public GameObject Quadro;
    public GameObject Cofre;
    public GameObject ObjetoDentro;
    public GameObject CofreAbertoSprite;

    public SpriteRenderer ChaveSprite;
    public AudioSource Queda;

    private bool isCofreAberto = false;



    public void ShowObject()
    {
        KeyPad.SetActive(true);
    }

    public void HideObject()
    {
        KeyPad.SetActive(false);
    }

    public void RemoverQuadro()
    {

        //Quadro.SetActive(false);
        Quadro.GetComponent<Animator>().SetBool("RemoveuQuadro", true);
        Queda.Play();
        RemoveuQuadro = true;

    }

    public bool QuadroNaParede()
    {
        if (!RemoveuQuadro)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public void AbirCofre()
    {
        isCofreAberto = true;
        ChaveSprite.sortingOrder = 4;
        KeyPad.SetActive(false);
        CofreAbertoSprite.SetActive(true);
        //Cofre.SetActive(false); // nao vai ser assim
    }


    public bool CofreAberto()
    {
        return isCofreAberto;
    }

    public void PegarObjetoDentro()
    {
        ObjetoDentro.SetActive(false);
    }

}
