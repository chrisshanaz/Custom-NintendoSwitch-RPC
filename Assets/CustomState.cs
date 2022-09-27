using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomState : MonoBehaviour
{
    public bool isPlayerCount;

    public void Edited()
    {
        if (isPlayerCount)
        {
            GetComponent<StatusChanger>().stateOverride = "In Game (" + GetComponent<InputField>().text + "/8)";
        }
        else
        {
            GetComponent<StatusChanger>().stateOverride = GetComponent<InputField>().text;
        }
        GetComponent<StatusChanger>().ApplyOverride();
    }
}
