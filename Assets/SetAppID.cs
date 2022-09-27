using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAppID : MonoBehaviour
{
    public Discord_Controller disc;
    public long id;

    public void Awake()
    {
        disc.applicationID = id;
        
    }
}
