using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject oldMan;
    public GameObject frustratedWoman;
    public GameObject eccentricMan;
    public GameObject shadyMan;



   

    private void Update()
    {
        if (oldMan == null)
        {
            if (frustratedWoman == null)
            {
                if(eccentricMan == null)
                {
                    if (shadyMan == null)
                    {
                        SceneManager.LoadScene("Credits");
                    }
                }
            }
        }
    }



}




    
       
    


