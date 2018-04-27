using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayPref : MonoBehaviour
{

    // Since Playerprefs only uses int, float, and string, this is what we will use.
    public int myInt = 0;
    public float myFloat = 0.00f;
    public string myString = "Enter Info Here";

    // In the start function I have it checking for a playerpref and assign its value to a variable.
    // This is done by the "Get" member of the class. Essentially its "getting" the value of the playerpref and assigning it to our variable.
    void Start()
    {
        myInt = PlayerPrefs.GetInt("PlayerPref_INT");
        myFloat = PlayerPrefs.GetFloat("PlayerPref_FLOAT");
        myString = PlayerPrefs.GetString("PlayerPref_STRING");

        // This line here is just showing the name of the level in the debug log.
        Debug.Log("Current Level is " + Application.loadedLevelName);
    }

    // This function creates a small GUI TextArea so we can add whatever value we want to the declared string.
    void OnGUI()
    {
        myString = GUI.TextArea(new Rect(10, 10, 100, 25), myString);
    }

    // In the update function I'm just making it possible to iterate the Int and Float variables.
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            myInt++;
        }

        if (Input.GetButtonUp("Fire2"))
        {
            myFloat += 0.01f;
        }

        // Here I have it so what when you press the space bar you "save" the variables and load the next level.
        // This is done by the "Set" member of the class. Essentially its "setting" the value of our variable to the playerpref.
        if (Input.GetButtonUp("Jump"))
        {
            PlayerPrefs.SetInt("PlayerPref_INT", myInt);
            PlayerPrefs.SetFloat("PlayerPref_FLOAT", myFloat);
            PlayerPrefs.SetString("PlayerPref_STRING", myString);

            // This line here is used to load a level. You can use the level index seen in the build options, or you can simply use the name of the level.
           // Application.LoadLevel("Tutorial 1");
        }
    }
}
