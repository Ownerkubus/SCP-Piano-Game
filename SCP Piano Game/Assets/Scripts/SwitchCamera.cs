using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{

    public GameObject Piano;
    public GameObject Character;
    public static bool failed = false;

    // Start is called before the first frame update
    void Start()
    {
        Piano.SetActive(true);
        Character.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            //Piano.SetActive(!Piano.activeInHierarchy);
            //Character.SetActive(!Character.activeInHierarchy);
            Piano.SetActive(false);
            Character.SetActive(true);
            failed = true;
        }

        if(Piano.activeInHierarchy == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (Piano.activeInHierarchy == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

    }
}
