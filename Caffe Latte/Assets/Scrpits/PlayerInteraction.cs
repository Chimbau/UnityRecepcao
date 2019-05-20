using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    //status das ranges das interações
    private bool rangePanel;
    private bool rangeSound;
    private bool rangeTelefone;
    private bool rangeXicara;
    private bool rangeBalcaoXicara;
    private bool rangeCofre;
    private bool rangePorta;

    public bool temChave;
    private bool temLanterna;
    private bool visao1Foi;


    public bool CarregandoXicara;
    private Color QualXicara;
    private int LugarXicara;
   


    private InteractionPanel Focus;
    private InteractionSound FocusSound;
    private InteractionDialog FocusDialog;
    private InteractionCofre FocusCofre;
    

    public InteractionXicara FocusXicara;
    private InteractionXicara FocusXicara1;

    public GameObject Xicara;
    public GameObject Chave;
    public GameObject Porta;
    public GameObject WinPanel;

    public SpriteRenderer XicaraSprite;

    
    // Start is called before the first frame update
    void Start()
    {

        rangePanel = false;
        rangeSound = false;
        rangeXicara = false;
        rangeTelefone = false;
        rangeCofre = false;
        rangePorta = false;
        temChave = false;
        temLanterna = false;
        visao1Foi = false;
        
        
        CarregandoXicara = false;
        QualXicara = Color.black;
        LugarXicara = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (rangePanel)
            {   
                //if (!visao1Foi){
                     Focus.ShowObject();
                     Focus.HideCloseMessage();
                     //visao1Foi = true;
               // }else{
                   // Focus.ShowObject2();
               // }


            }

            if (rangeSound)
            {
                FocusSound.PlaySino();
            }

            if (rangeTelefone)
            {

                if (FocusDialog.EstaTocando())
                {
                    FocusDialog.ShowObject();
                    FocusDialog.HideCloseMessage();
                    rangeTelefone = false;
                }
               
            }

            if (rangeXicara)
            {
                if (!CarregandoXicara)
                {
                    QualXicara = FocusXicara.PegarXicara(LugarXicara);
                    if (QualXicara != Color.black) //retorna cinza se nao tem xicara no lugar e preto se nao tem mais nenhuma xicara no balcao
                    {
                        CarregandoXicara = true;
                        Xicara.SetActive(true);
                        XicaraSprite.color = QualXicara;


                    }
                    else
                    {

                        if (rangeBalcaoXicara && FocusXicara.SemXicaraBalcao())
                        {
                            FocusXicara.ShowBalcaoMessage();
                        }
                    }

                }
                else
                {
                    if(FocusXicara.DeixarXicara(LugarXicara, QualXicara))
                    {
                        CarregandoXicara = false;
                        Xicara.SetActive(false);
                    }
                   
                            
                }
                             
            }

            if (rangeCofre)
            {
                if (FocusCofre.QuadroNaParede())
                {
                    FocusCofre.RemoverQuadro();
                }
                else
                {
                    if (!FocusCofre.CofreAberto())
                    {
                        FocusCofre.ShowObject();
                    }
                    else
                    {
                        FocusCofre.PegarObjetoDentro();
                        temChave = true;
                        Chave.SetActive(true);
                    }
                    
                }
                
            }


            if (rangePorta && temChave) 
            {
                Chave.SetActive(false);
                Focus.HideCloseMessage();
                WinPanel.SetActive(true);
            }
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "InteractionPanel")
        {

            Focus = other.GetComponent<InteractionPanel>();
            InteractionPanelEnter(Focus);

        }


        if (other.tag == "InteractionSound")
        {

            FocusSound = other.GetComponent<InteractionSound>();
            InteractionSoundEnter(FocusSound);

        }

        if (other.tag == "Telefone")
        {
            FocusDialog = other.GetComponent<InteractionDialog>();
            InteractionDialogEnter(FocusDialog);

        }

        /*if (other.tag == "Xicaras")
        {
            FocusXicara = other.GetComponent<InteractionXicara>();
            InteractionXicaraEnter(FocusXicara);
        }*/


        if (other.tag == "LugarXicara1")
        {
            //FocusXicara = other.GetComponent<InteractionXicara>();
            InteractionXicaraEnter(FocusXicara);
            LugarXicara = 0;

        }

        if (other.tag == "LugarXicara2")
        {
            //FocusXicara = other.GetComponent<InteractionXicara>();
            InteractionXicaraEnter(FocusXicara);
            LugarXicara = 1;

        }

        if (other.tag == "LugarXicara3")
        {
            //FocusXicara = other.GetComponent<InteractionXicara>();
            InteractionXicaraEnter(FocusXicara);
            LugarXicara = 2;

        }

        if (other.tag == "LugarXicara4")
        {
            //FocusXicara = other.GetComponent<InteractionXicara>();
            InteractionXicaraEnter(FocusXicara);
            LugarXicara = 3;

        }

        if (other.tag == "LugarXicara5")
        {
            //FocusXicara = other.GetComponent<InteractionXicara>();
            InteractionXicaraEnter(FocusXicara);
            LugarXicara = 4;

        }

        if (other.tag == "LugarXicara6")
        {
            //FocusXicara = other.GetComponent<InteractionXicara>();
            InteractionXicaraEnter(FocusXicara);
            LugarXicara = 5;

        }

        if (other.tag == "BalcaoXicaras")
        {
            InteractionBalcaoXEnter(FocusXicara);
        }

        if (other.tag == "Cofre")
        {
            FocusCofre = other.GetComponent<InteractionCofre>();
            InteractionCofreEnter(FocusCofre);
        }

        if (other.tag == "Porta")
        {
            Focus = other.GetComponent<InteractionPanel>();
            Focus.ShowCloseMessage();
            rangePorta = true;
        }
        
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "InteractionPanel")
        {

            InteractionPanelExit();
        }

        if (other.tag == "InteractionSound")
        {
            InteractionSoundExit();
        }

        if (other.tag == "Telefone")
        {
       
            InteractionDialogExit(FocusDialog);

        }

        /* if (other.tag == "Xicaras")
         {

             InteractionXicaraExit();
         }*/


        if (other.tag == "LugarXicara1")
        {
            InteractionXicaraExit();

        }

        if (other.tag == "LugarXicara2")
        {
            InteractionXicaraExit();

        }

        if (other.tag == "LugarXicara3")
        {
            InteractionXicaraExit();
        }

        if (other.tag == "LugarXicara4")
        {
            InteractionXicaraExit();
        }

        if (other.tag == "LugarXicara5")
        {
            InteractionXicaraExit();
        }

        if (other.tag == "LugarXicara6")
        {
            InteractionXicaraExit();
        }


        if (other.tag == "BalcaoXicaras")
        {
            InteractionBalcaoXExit();
        }

        if (other.tag == "Cofre")
        {
           
            InteractionCofreExit();
        }

        if (other.tag == "Porta")
        {
            rangePorta = false;
            Focus.HideCloseMessage();
        }
    }

    //Interação com Paines : Papel, keypad
    public void InteractionPanelEnter(InteractionPanel Focus)
    {
        rangePanel = true;
        Focus.ShowCloseMessage();
    }


    public void InteractionPanelExit()
    {
        rangePanel = false;
        Focus.HideCloseMessage();
        Focus.HideObject();
    }


    //Interações que geram sons : sino
    public void InteractionSoundEnter(InteractionSound FocusSound)
    {
        rangeSound = true;
        FocusSound.ShowCloseMessage();
    }


    public void InteractionSoundExit()
    {
        rangeSound = false;
        FocusSound.HideCloseMessage();
    }



    //Interação com o telefone
    public void InteractionDialogEnter(InteractionDialog FocusDialog)
    {
        rangeTelefone = true;
        FocusDialog.ShowCloseMessage();
    }

    public void InteractionDialogExit(InteractionDialog FocusDialog)
    {
        rangeTelefone = false;
        FocusDialog.HideCloseMessage();
    }


    //Interação Xicara
    public void InteractionXicaraEnter(InteractionXicara FocusXicara)
    {
        rangeXicara = true;
      
    }

    public void InteractionXicaraExit()
    {
        rangeXicara = false;

    }

    //Interação balcao xicaras
    public void InteractionBalcaoXEnter(InteractionXicara FocusXicara)
    {
        rangeBalcaoXicara = true;

    }

    public void InteractionBalcaoXExit()
    {
        rangeBalcaoXicara = false;
        FocusXicara.HideBalcaoMessage();

    }

    public void InteractionCofreEnter(InteractionCofre FocusCofre)
    {
        rangeCofre = true;
    }

    public void InteractionCofreExit()
    {
        rangeCofre = false;
        FocusCofre.HideObject();
    }



}
