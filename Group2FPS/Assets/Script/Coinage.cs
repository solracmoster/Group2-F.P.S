using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Coinage : MonoBehaviour {

	// Use this for initialization
	
    public int coin = 0;

    void Start () {
        //DontDestroyOnLoad(this.gameObject);
        PlayerPrefs.SetInt("Coin", coin);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown ("p"))
        {
            //reload the scene
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("Tutorial");

        }

    }


    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Coin"))
        {
            PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + 1);
            Soundmanagerscript.PlaySound("Coin");
            

            Debug.Log("Coin");
        }

       
    }

    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") - 1);
            Soundmanagerscript.PlaySound("Death");
            Soundmanagerscript.PlaySound("Drop");
        }

    }

}