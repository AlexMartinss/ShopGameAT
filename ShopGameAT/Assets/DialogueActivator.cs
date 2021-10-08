using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour
{
    public GameObject OldMan;
    public GameObject IrritatedWoman;
    public GameObject EccentricMan;
    public GameObject ShadyMan;
  


    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "OldMan")
        
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                OldMan.gameObject.SetActive(true);

            }
            
        }

        if (collision.gameObject.tag == "IrritatedWoman")

        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                IrritatedWoman.gameObject.SetActive(true);

            }

        }

        if (collision.gameObject.tag == "EccentricMan")

        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EccentricMan.gameObject.SetActive(true);

            }

        }

        if (collision.gameObject.tag == "ShadyMan")

        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ShadyMan.gameObject.SetActive(true);

            }

        }
    }
}
