using System.Collections;
using System.Collections.Generic;
using Unity.LEGO.Behaviours;
using Unity.LEGO.Behaviours.Triggers;
using UnityEngine;

public class CustomTouchTrigger : TouchTrigger
{
    GameObject obj;
    protected override void Start()
    {
        obj = GameObject.FindWithTag("TouchTrigger");
        CustomTouchTrigger action = obj.GetComponent<CustomTouchTrigger>();
        base.Start();

        if (IsPlacedOnBrick())
        {
            // Add SensoryCollider to all brick colliders.
            foreach (var brick in m_ScopedBricks)
            {
                foreach (var part in brick.parts)
                {
                    foreach (var collider in part.colliders)
                    {
                        var sensoryCollider = LEGOBehaviourCollider.Add<SensoryCollider>(collider, m_ConnectedBricks, 0.64f);
                        SetupSensoryCollider(sensoryCollider);
                    }
                }
            }
        }

        
        
    }

}
