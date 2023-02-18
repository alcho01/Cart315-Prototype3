using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flashlight : MonoBehaviour
{
    PlayerControls controls;

    [SerializeField] GameObject FlashlightLight;
    private bool FlashlightActive = false;

    void Awake() 
    {
        controls = new PlayerControls();

        controls.Player.Flashlight.performed += ctx => LightOn();
    }

    // Start is called before the first frame update
    void Start()
    {
            FlashlightLight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LightOn()
    {
        if (FlashlightActive == false)
        {
            FlashlightLight.gameObject.SetActive(true);
            FlashlightActive = true;
        }
        else
        {
            FlashlightLight.gameObject.SetActive(false);
            FlashlightActive = false;
        }
    }

    void OnEnable()
    {
        controls.Player.Enable();
    }

    void OnDisable()
    {
        controls.Player.Disable();
    }
}
