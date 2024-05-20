using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerThings : MonoBehaviour
{
    [SerializeField] private TMP_InputField InField;
    [SerializeField] private GameObject fuego;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DoThinghy(InField.text);
            InField.text = null;
            InField.Select();
            InField.ActivateInputField();

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Enter key was pressed.");
        }
    }

    private void DoThinghy(string inp)
    {
        if (inp=="fire")
        {
            Instantiate(fuego, transform.position,Quaternion.identity);
        }
    }
}
