using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform player;
    
   
    
    public void teleportPoint()
    {
        for (int i = 0; i < Uimanager.instance.intructionPanel.Length; i++)
        {
            Uimanager.instance.intructionPanel[i].SetActive(false);
        }
        
        player.transform.position = new Vector3(this.transform.position.x, player.transform.position.y, this.transform.position.z);
    }
}
