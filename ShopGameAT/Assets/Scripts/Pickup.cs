using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject Base;
    public GameObject Package;
    public GameObject EDrink;
    public GameObject Perfume;
    public GameObject Cane;

    
    public bool package;
    public bool eDrink;
    public bool perfume;
    public bool cane;

    public AudioSource pickUpSound;




    void Start()
    {
        Base.gameObject.SetActive(true);
        Package.gameObject.SetActive(false);
        EDrink.gameObject.SetActive(false);
        Perfume.gameObject.SetActive(false);
        Cane.gameObject.SetActive(false);

    }

    private void Update()
    {
        if (package == true && Input.GetKeyDown(KeyCode.E))
        {
            pickUpSound.Play();

            Base.gameObject.SetActive(false);
            EDrink.gameObject.SetActive(false);
            Package.gameObject.SetActive(true);
            Perfume.gameObject.SetActive(false);
            Cane.gameObject.SetActive(false);
        }
        if (eDrink == true && Input.GetKeyDown(KeyCode.E))
        {
            pickUpSound.Play();

            Base.gameObject.SetActive(false);
            EDrink.gameObject.SetActive(true);
            Package.gameObject.SetActive(false);
            Perfume.gameObject.SetActive(false);
            Cane.gameObject.SetActive(false);
        }
        if (perfume == true && Input.GetKeyDown(KeyCode.E))
        {
            pickUpSound.Play();

            Base.gameObject.SetActive(false);
            EDrink.gameObject.SetActive(false);
            Package.gameObject.SetActive(false);
            Perfume.gameObject.SetActive(true);
            Cane.gameObject.SetActive(false);
        }
        if (cane == true && Input.GetKeyDown(KeyCode.E))
        {
            pickUpSound.Play();

            Base.gameObject.SetActive(false);
            EDrink.gameObject.SetActive(false);
            Package.gameObject.SetActive(false);
            Perfume.gameObject.SetActive(false);
            Cane.gameObject.SetActive(true);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Package")
        {
            package = true;
        }

        if (collision.gameObject.tag == "EDrink")
        {
            eDrink = true;
        }

        if (collision.gameObject.tag == "Perfume")
        {
            perfume = true;
        }

        if (collision.gameObject.tag == "Cane")
        {
            cane = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Package")
        {
            package = false;
        }

        if (collision.gameObject.tag == "EDrink")
        {
            eDrink = false;
        }

        if (collision.gameObject.tag == "Perfume")
        {
            perfume = false;
        }

        if (collision.gameObject.tag == "Cane")
        {
            cane = false;
        }
    }
}
