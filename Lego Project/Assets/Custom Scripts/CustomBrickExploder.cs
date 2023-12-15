using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.LEGO.Behaviours.Actions;
public class CustomBrickExploder : CustomExplodeAction
{
    GameObject obj; 
    protected override void Start()
    {
        obj = GameObject.FindWithTag("Elevator");
        CustomBrickExploder action = obj.GetComponent<CustomBrickExploder>();
        action.m_AudioVolume = 0f;
        action.Activate();
        
    }
}
