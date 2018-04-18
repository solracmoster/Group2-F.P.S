using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COuntdown : MonoBehaviour
{

    public float timeLeft = 5.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health") - 10);
        }
    }
}