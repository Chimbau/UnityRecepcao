using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternaScript : MonoBehaviour
{

    public Transform PlayerPosition;
  



    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 resultVecotr = Input.mousePosition - pos;
        float mouseAngulo = -Mathf.Atan2(resultVecotr.x, resultVecotr.y) * Mathf.Rad2Deg;
        transform.position = PlayerPosition.position;
        transform.rotation = Quaternion.AngleAxis(mouseAngulo+90, Vector3.forward);
    }
}
