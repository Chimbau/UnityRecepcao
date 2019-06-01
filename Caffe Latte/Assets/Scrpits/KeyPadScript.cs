﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPadScript : MonoBehaviour
{

    private int[] sequencia = new int[4];
    private int index = 0;
    private int[] senha = new int[4];

    public Text numero;
    public InteractionCofre Cofre;

    public Text[] PainelNumeros = new Text[4];

    // Start is called before the first frame update
    void Start()
    {
        senha[0] = 8;
        senha[1] = 3;
        senha[2] = 9;
        senha[3] = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Click1()
    {
        if (index < sequencia.Length)
        {
            sequencia[index] = 1;
            PainelNumeros[index].text = "1";
            index++;
        }
       
    }

    public void Click2()
    {
        if (index < sequencia.Length)
        {
            sequencia[index] = 2;
            PainelNumeros[index].text = "2";
            index++;
        }
    }

    public void Click3()
    {
        if (index < sequencia.Length)
        {
            sequencia[index] = 3;
            PainelNumeros[index].text = "3";
            index++;
        }
    }

    public void Click4()
    {
        if (index < sequencia.Length)
        {
            sequencia[index] = 4;
            PainelNumeros[index].text = "4";
            index++;
        }
    }

    public void Click5()
    {
        if (index < sequencia.Length)
        {
            sequencia[index] = 5;
            PainelNumeros[index].text = "5";
            index++;
        }
    }

    public void Click6()
    {
        if (index < sequencia.Length)
        {
            sequencia[index] = 6;
            PainelNumeros[index].text = "6";
            index++;
        }
    }

    public void Click7()
    {
        if (index < sequencia.Length)
        {
            sequencia[index] = 7;
            PainelNumeros[index].text = "7";
            index++;
        }
    }

    public void Click8()
    {
        if (index < sequencia.Length)
        {
            sequencia[index] = 8;
            PainelNumeros[index].text = "8";
            index++;
        }
    }

    public void Click9()
    {
        if (index < sequencia.Length)
        {
            sequencia[index] = 9;
            PainelNumeros[index].text = "9";
            index++;
        }
    }

    public void Click0()
    {
        if (index < sequencia.Length)
        {
            sequencia[index] = 0;
            PainelNumeros[index].text = "0";
            index++;
        }
    }

    public void Submit()
    {
        bool Checar = true;
        for (int i = 0; i < 4 ; i++)
        {
            if (sequencia[i] != senha[i])
            {
                Checar = false;
                            
            }
        }

        if (Checar)
        {
            if (!Cofre.CofreAberto())
            {
                Cofre.AbirCofre();
            }
         
            Debug.Log("Senha correta");
        }
        else
        {
            for (int i = 0; i < 4; i++)
            {
                sequencia[i] = 0;
                PainelNumeros[i].text = "";
            }
            Debug.Log("Senha incorreta");
        }

        Checar = false;
        index = 0;



    }

    

}
