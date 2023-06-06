using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasLookAt : MonoBehaviour
{
    public static canvasLookAt instance;
    [SerializeField] Transform player;
    public GameObject instructionUi;
    public Transform point;


    [SerializeField] GameObject[] allButton;
    public GameObject nearObj;
    float dist;
    float nearDist = 8;
    private void Awake()
    {
        instance = this;     
    }

    private void Start()
    {
        for (int i = 0; i < Uimanager.instance.intructionPanel.Length; i++)
        {
            Uimanager.instance.intructionPanel[i].SetActive(false);
        }
    }

    private void Update()
    {

        transform.LookAt(player.transform.position);     
    }

    public void ShowPopUp()
    {

        
        allButton = GameObject.FindGameObjectsWithTag("interact");
        for (int i = 0; i < allButton.Length; i++)
        {
            dist = Vector3.Distance(point.position, allButton[i].transform.position);
            if (dist < nearDist)
            {
                allButton[i].GetComponent<Button>().onClick.Invoke();
                break;
            }
        }

        instructionUi.SetActive(true);
    }

   
}

    
