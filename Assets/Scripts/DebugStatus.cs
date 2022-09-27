using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugStatus : MonoBehaviour
{
    public Text det;
    public Text state;

    public Discord_Controller disc;

    public void Awake()
    {
        disc = FindObjectOfType<Discord_Controller>();
    }

    public void Update()
    {
        det.text = disc.GetComponent<Discord_Controller>().details;
        state.text = disc.GetComponent<Discord_Controller>().state;
    }
}
