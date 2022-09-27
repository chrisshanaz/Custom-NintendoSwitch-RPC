using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusChanger : MonoBehaviour
{
    public string detailOverride;
    public string stateOverride;

    public Discord_Controller disc;

    public void Start()
    {
        disc = FindObjectOfType<Discord_Controller>();
    }

    public void ApplyOverride()
    {
        if(detailOverride != "")
        {
            disc.details = detailOverride;
            FindObjectOfType<ButtonHolder>().isPicked = true;
        }
        if (stateOverride != "")
        {
            disc.state = stateOverride;
        }

        try
        {
            foreach(Button option in GetComponentInParent<ButtonHolder>().butt)
            {
                option.gameObject.GetComponent<Image>().color = Color.red;
            }
            GetComponent<Image>().color = Color.green;
        }
        catch
        {

        }
    }
}
