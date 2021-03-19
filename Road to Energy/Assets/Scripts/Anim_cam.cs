using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Anim_cam : MonoBehaviour
{
    public float senc = 10f;
    private float posX, posY;
    public float differenceX = 50000f, differenceY=50000f;




    void Update()
    {
        posX = -Input.GetAxis("Mouse X");
        posY = -Input.GetAxis("Mouse Y");
        if (Math.Abs(gameObject.transform.position.x + posX) < Math.Abs(differenceX) && Math.Abs(gameObject.transform.position.y + posY) < Math.Abs(differenceY))
        { 
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + posX / senc, gameObject.transform.position.y + posY / senc, gameObject.transform.position.z);
        }
    }
}
