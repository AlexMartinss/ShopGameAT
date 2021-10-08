using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveItem : MonoBehaviour
{

    public GameObject Normal;
    public GameObject Package;
    public GameObject Perfume;
    public GameObject EDrink;
    public GameObject Cane;



    public GameObject OldMan;
    public GameObject EccentricMan;
    public GameObject FrustratedWoman;
    public GameObject ShadyMan;

    public bool nearOldMan;
    public bool nearEccentricMan;
    public bool nearFrustratedWoman;
    public bool nearShadyMan;

    public AudioSource Correct;
    public AudioSource Incorrect;



   

    private void Update()
    {
        

        if (nearOldMan == true && Input.GetKeyDown(KeyCode.F))
        {
            

            if (Cane.activeInHierarchy)
            {
                Correct.Play();
                OldMan.GetComponent<Animator>().Play("OldManWalkAway");
                Destroy(OldMan, 3);
            }
            else
            {
                Incorrect.Play();
                OldMan.GetComponent<Animator>().Play("OldManWalkAway");
                Destroy(OldMan, 3);
            }
            Normal.gameObject.SetActive(true);
            Package.gameObject.SetActive(false);
            Perfume.gameObject.SetActive(false);
            EDrink.gameObject.SetActive(false);
            Cane.gameObject.SetActive(false);
        }

        if (nearShadyMan == true && Input.GetKeyDown(KeyCode.F))
        {
            

            if (Package.activeInHierarchy)
            {
                Correct.Play();
                ShadyMan.GetComponent<Animator>().Play("ShadyManWalkAway");
                Destroy(ShadyMan, 3);
            }
            else
            {
                Incorrect.Play();
                ShadyMan.GetComponent<Animator>().Play("ShadyManWalkAway");
                Destroy(ShadyMan, 3);
            }
            Normal.gameObject.SetActive(true);
            Package.gameObject.SetActive(false);
            Perfume.gameObject.SetActive(false);
            EDrink.gameObject.SetActive(false);
            Cane.gameObject.SetActive(false);

        }

        if (nearFrustratedWoman == true && Input.GetKeyDown(KeyCode.F))
        {
           

            if (Perfume.activeInHierarchy)
            {
                Correct.Play();
                FrustratedWoman.GetComponent<Animator>().Play("IrritatedWomanWalkAway");
                Destroy(FrustratedWoman, 3);
            }
            else
            {
                Incorrect.Play();
                FrustratedWoman.GetComponent<Animator>().Play("IrritatedWomanWalkAway");
                Destroy(FrustratedWoman, 3);
            }
            Normal.gameObject.SetActive(true);
            Package.gameObject.SetActive(false);
            Perfume.gameObject.SetActive(false);
            EDrink.gameObject.SetActive(false);
            Cane.gameObject.SetActive(false);

        }

        if (nearEccentricMan == true && Input.GetKeyDown(KeyCode.F))
        {
            

            if (EDrink.activeInHierarchy)
            {
                Correct.Play();
                EccentricMan.GetComponent<Animator>().Play("EccentricManWalkAway");
                Destroy(EccentricMan, 3);


            }
            else
            {
                Incorrect.Play();
                EccentricMan.GetComponent<Animator>().Play("EccentricManWalkAway");
                Destroy(EccentricMan, 3);


            }
            Normal.gameObject.SetActive(true);
            Package.gameObject.SetActive(false);
            Perfume.gameObject.SetActive(false);
            EDrink.gameObject.SetActive(false);
            Cane.gameObject.SetActive(false);

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
            nearFrustratedWoman = true;

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
            nearFrustratedWoman = false;

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


