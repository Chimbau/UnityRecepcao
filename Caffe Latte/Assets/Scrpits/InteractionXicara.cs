using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionXicara : MonoBehaviour
{

    public GameObject BalcaoMessage;

    public GameObject[] Xicaras = new GameObject[6];
    public SpriteRenderer[] xicarasSprites = new SpriteRenderer[6];

    //private int index = 0;
    

    public void Start()
    {

        xicarasSprites[0].color = Color.red;
        xicarasSprites[1].color = Color.green;
        xicarasSprites[2].color = Color.yellow;

        xicarasSprites[3].color = Color.red;
        xicarasSprites[4].color = Color.green;
        xicarasSprites[5].color = Color.yellow;


    }

    public Color PegarXicara(int LugarXicara)
    {
       if (Xicaras[LugarXicara].activeSelf)
       {
            Xicaras[LugarXicara].SetActive(false);
            return QualCor(LugarXicara);
       }

       
        return Color.black;
        
             
    }

    public bool DeixarXicara(int LugarXicara, Color QualXicara)
    {
        if (!Xicaras[LugarXicara].activeSelf)
        {
            Xicaras[LugarXicara].SetActive(true);
            xicarasSprites[LugarXicara].color = QualXicara;
            return true;
        }
        return false;
      
    }

    public Color QualCor(int index)
    {
        if(xicarasSprites[index].color == Color.red)
        {
            return Color.red;

        }

        if (xicarasSprites[index].color == Color.green)
        {
            return Color.green;

        }

        if (xicarasSprites[index].color == Color.yellow)
        {
            return Color.yellow;

        }

        return Color.black;

    }

    public bool SemXicaraBalcao()
    {
        for(int i = 0 ; i < 3 ; i++)
        {
            if (Xicaras[i].activeSelf)
            {
                return false;
            }
        }
        return true;
    }

    public void ShowBalcaoMessage()
    {
        BalcaoMessage.SetActive(true);
    }

    public void HideBalcaoMessage()
    {
        BalcaoMessage.SetActive(false);
    }


}
