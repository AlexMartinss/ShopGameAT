using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectItem : MonoBehaviour
{
    public GameObject correctDialogue;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "OldMan")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                correctDialogue.gameObject.SetActive(true);
            }
        }
    }
}
