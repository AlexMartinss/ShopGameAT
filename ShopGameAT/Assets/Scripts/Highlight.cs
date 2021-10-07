using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public GameObject normal;
    public GameObject highlight;


    private void Start()
    {
        normal.gameObject.SetActive(true);
        highlight.gameObject.SetActive(false);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            normal.gameObject.SetActive(true);
            highlight.gameObject.SetActive(false);
        }
        else
        {
            normal.gameObject.SetActive(false);
            highlight.gameObject.SetActive(true);
        }
    }

   

    
}
