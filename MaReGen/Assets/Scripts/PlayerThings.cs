using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerThings : MonoBehaviour
{
    [SerializeField] private TMP_InputField InField;

    #region gameobjects
    [SerializeField] private GameObject water;
    [SerializeField] private GameObject fire;
    [SerializeField] private GameObject tornado;
    #endregion
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
    }

    private void DoThinghy(string inp)
    {
        if (inp=="fire")
        {
            Instantiate(fire, transform.position,Quaternion.identity);
        }

        if (inp == "tornado")
        {
            Instantiate(tornado, transform.position, Quaternion.identity);
        }

        if (inp == "water")
        {
            Instantiate(water, transform.position, Quaternion.identity);
        }
    }
}
