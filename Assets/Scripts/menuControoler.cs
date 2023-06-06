using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class menuControoler : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera cinemachineVirtualCamera;
    private CinemachinePOV cinemachinePOV;
    private void Start()
    {

        cinemachinePOV = cinemachineVirtualCamera.GetCinemachineComponent<CinemachinePOV>();
        cinemachinePOV.m_HorizontalAxis.m_MaxSpeed = 0;
        cinemachinePOV.m_VerticalAxis.m_MaxSpeed = 0;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            cinemachinePOV.m_HorizontalAxis.m_MaxSpeed = 150;
            cinemachinePOV.m_VerticalAxis.m_MaxSpeed = 150;
        }
        else
        {
            cinemachinePOV.m_HorizontalAxis.m_MaxSpeed = 0;
            cinemachinePOV.m_VerticalAxis.m_MaxSpeed = 0;
        }
    }
}
