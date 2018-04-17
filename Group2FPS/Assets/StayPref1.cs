using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayPref1 : MonoBehaviour
{

    // Since Playerprefs only uses int, float, and string, this is what we will use.
    public int money = 0;
   

    // In the start function I have it checking for a playerpref and assign its value to a variable.
    // This is done by the "Get" member of the class. Essentially its "getting" the value of the playerpref and assigning it to our variable.
    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
       

        // This line here is just showing the name of the level in the debug log.
        Debug.Log("Current Level is " + Application.loadedLevelName);
    }

    // This function creates a small GUI TextArea so we can add whatever value we want to the declared string.
    

    // In the update function I'm just making it possible to iterate the Int and Float variables.
    void Update()
    {
        //if (Input.GetButtonUp("Fire1"))
       // {
        //    money++;
        //}


        // Here I have it so what when you press the space bar you "save" the variables and load the next level.
        // This is done by the "Set" member of the class. Essentially its "setting" the value of our variable to the playerpref.
        //if (Input.GetButtonUp("Jump"))
        //{
        //    PlayerPrefs.SetInt("Money", money);
           

           
       // }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Coin"))
        {
            money++;
            PlayerPrefs.SetInt("Money", money);
        }

        


    }
}
