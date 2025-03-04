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
    public ProjectilesHolderScript Projectiles;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Vamos a imprimir las weas del diccionario");
        foreach (var kvp in Projectiles.projectilesDict)
        {
            Debug.Log("Clave: " + kvp.Key + ", GameObject: " + kvp.Value.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DoThinghy(InField.text.ToLower());
            InField.text = null;
            InField.Select();
            InField.ActivateInputField();

        }
    }

    private void DoThinghy(string inp)
    {
        if (Projectiles.projectilesDict.ContainsKey(inp))
        {
            Instantiate(Projectiles.projectilesDict[inp], transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("No existe ese poder"); //hacer un pop up ingame que diga eso
        }
    }
}
