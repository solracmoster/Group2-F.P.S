using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackeR : MonoBehaviour
{

    // Since Playerprefs only uses int, float, and string, this is what we will use.
    public int Track1 = 0;
   

    // In the start function I have it checking for a playerpref and assign its value to a variable.
    // This is done by the "Get" member of the class. Essentially its "getting" the value of the playerpref and assigning it to our variable.
    void Start()
    {
        Track1 = PlayerPrefs.GetInt("Track1");
       

      
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Track1"))
        {
            Track1++;
            PlayerPrefs.SetInt("Track1", Track1);
        }

        


    }
}
