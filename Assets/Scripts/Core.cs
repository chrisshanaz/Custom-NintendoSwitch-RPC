using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public GameObject[] menus;

    public void ActivateMenu(int menuToKeep)
    {
        foreach(GameObject menu in menus)
        {
            menu.SetActive(false);
        }
        menus[menuToKeep].SetActive(true);
    }

    public void ApplyStatus()
    {
        FindObjectOfType<Discord_Controller>().UpdateStatus();
    }
}
