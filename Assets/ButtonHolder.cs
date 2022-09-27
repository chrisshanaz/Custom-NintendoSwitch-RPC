using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHolder : MonoBehaviour
{
    public Button[] butt;
    public bool isPicked = false;
    public Button done;
    public Text warning;

    public void Update()
    {
        if (!isPicked)
        {
            warning.gameObject.SetActive(true);
            done.interactable = false;
        }
        else
        {
            warning.gameObject.SetActive(false);
            done.interactable = true;
        }
    }
}
