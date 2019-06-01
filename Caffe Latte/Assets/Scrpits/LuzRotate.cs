using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzRotate : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform PlayerPosition;
    private Vector3 v;


    public PlayerMovement PlayerScript;
    public SpriteRenderer sprite;

    private float SpriteTamanho = 1.77f;


    void Start()
    {
        //sprite = GetComponent<SpriteRenderer>();
      
        

    }

    // Update is called once per frame
    void Update()
    {






        
        /*
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 resultVecotr = Input.mousePosition - pos;
        float mouseAngulo2 = -Mathf.Atan2(resultVecotr.x, resultVecotr.y) * Mathf.Rad2Deg;


        transform.localEulerAngles = new Vector3(0, 0, mouseAngulo2);
        //transform.rotation = Quaternion.AngleAxis(mouseAngulo, Vector3.forward);


        float ArrumarX = Mathf.Cos(Mathf.Deg2Rad * mouseAngulo) * 2.0f;
        //float ArrumarY = Mathf.Sin(Mathf.Deg2Rad * mouseAngulo) * SpriteTamanho;

        transform.localPosition = new Vector3(PlayerPosition.position.x+ArrumarX, transform.position.y, 0);
        //transform.localPosition = PlayerPosition.position;
        Debug.Log(Mathf.Cos(Mathf.Deg2Rad * mouseAngulo));
        //Debug.Log(ArrumarX);

        //Debug.Log(sprite.bounds.extents.y);

     



        


        //transform.rotation = Quaternion.AngleAxis(mouseAngulo+180, Vector3.forward);
        //Debug.Log(anguloRotate);*/
       
        float mouseAngulo = PlayerScript.PegarAnguloMouse();
        Debug.Log(mouseAngulo);
        float anguloAtual = transform.rotation.eulerAngles.z;
        float anguloRotate = mouseAngulo - anguloAtual +180;
        // transform.position = new Vector3(PlayerPosition.position.x + 2f, PlayerPosition.position.y+2f, 0);
        //transform.position = PlayerPosition.position + (transform.position - PlayerPosition.position).normalized * 1.5f;
        transform.position = PlayerPosition.position;
        transform.RotateAround(PlayerPosition.position, Vector3.forward, anguloRotate);   
    }
}
