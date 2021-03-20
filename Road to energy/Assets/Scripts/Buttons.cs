using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    [SerializeField] private Sprite button2;
    [SerializeField] private float coordY;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = button2;
            gameObject.GetComponent<Collider2D>().enabled = false;

            wall.transform.position += new Vector3(0, coordY, 0);
        }
    }
}
