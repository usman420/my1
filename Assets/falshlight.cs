using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falshlight : MonoBehaviour

    {
    private Light myLight;


    void Start()
    {
        myLight = GetComponent<Light>();
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}

