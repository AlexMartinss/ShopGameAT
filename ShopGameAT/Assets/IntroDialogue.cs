using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Animations;

public class IntroDialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject ThisDialogue;
    public GameObject continueButton;
    public GameObject textBox;
    public GameObject NPC;



    private void OnEnable()
    {
        textBox.gameObject.SetActive(true);
        StartCoroutine(Type());
    }

   

     void Update()
    {
     if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

     if (index >= 1)
        {
            textBox.gameObject.SetActive(false);
            continueButton.SetActive(false);
            ThisDialogue.gameObject.SetActive(false);
            
            
        }
    }


    IEnumerator Type()
    {

        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }
}
