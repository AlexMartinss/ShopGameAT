using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour
{
    public GameObject OldMan;
    public GameObject IrritatedWoman;
    public GameObject EccentricMan;
    public GameObject ShadyMan;

    public bool nearOldMan;
    public bool nearIrritatedWoman;
    public bool nearEccentricMan;
    public bool nearShadyMan;




    private void Update()
    {
        if (nearOldMan == true && Input.GetKeyDown(KeyCode.Space))
        {
            OldMan.gameObject.SetActive(true);
        }
        if (nearIrritatedWoman == true && Input.GetKeyDown(KeyCode.Space))
        {
            IrritatedWoman.gameObject.SetActive(true);
        }
        if (nearEccentricMan == true && Input.GetKeyDown(KeyCode.Space))
        {
            EccentricMan.gameObject.SetActive(true);
        }
        if (nearShadyMan == true && Input.GetKeyDown(KeyCode.Space))
        {
            ShadyMan.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "OldMan")
        
        {
            nearOldMan = true;
            
        }

        if (other.gameObject.tag == "IrritatedWoman")

        {
            nearIrritatedWoman = true;

        }

        if (other.gameObject.tag == "EccentricMan")

        {
            nearEccentricMan = true;
        }

        if (other.gameObject.tag == "ShadyMan")

        {
            nearShadyMan = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "OldMan")

        {
            nearOldMan = false;

        }

        if (other.gameObject.tag == "IrritatedWoman")

        {
            nearIrritatedWoman = false;

        }

        if (other.gameObject.tag == "EccentricMan")

        {
            nearEccentricMan = false;
        }

        if (other.gameObject.tag == "ShadyMan")

        {
            nearShadyMan = false;

        }
    }
}
