using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float yAxis, xAxis;
    private Rigidbody2D rb;
    private bool virou;
    private Vector3 mousePositon;


    public Transform SpriteMask;

    [SerializeField] private float speed = 5;


   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        virou = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        yAxis = Input.GetAxisRaw("Vertical");
        xAxis = Input.GetAxisRaw("Horizontal");
        mousePositon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        SpriteMask.position = new Vector3(mousePositon.x, mousePositon.y, 0);



    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(xAxis, yAxis) * speed;
        VirarPlayer();
       
     }



    public void VirarPlayer()
    {
        if (xAxis > 0 && virou == false)
        {
            transform.Rotate(new Vector3(0, 180, 0));
            virou = true;
        }

        if (xAxis < 0 && virou == true)
        {
            transform.Rotate(new Vector3(0, 180, 0));
            virou = false;
        }
    }
}


   







