using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uimanager : MonoBehaviour
{
    public static Uimanager instance;
    public GameObject[] intructionPanel;

    private void Awake()
    {
        instance = this;
    }
}
