using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_cam : MonoBehaviour
{
    private float senc = 10f;
    private float posX, posY;
    //void Start()
    //{
    //    posX = Input.mousePosition.x;
    //    posY = Input.mousePosition.y;
    //}

    
    void Update()
    {
        posX = -Input.GetAxis("Mouse X");
        posY = -Input.GetAxis("Mouse Y");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + posX/senc, gameObject.transform.position.y + posY/senc, gameObject.transform.position.z );
    }
}
