using System.Collections;
using System.Collections.Generic;
using Unity.LEGO.Behaviours.Actions;
using Unity.LEGO.Game;
using UnityEngine;

public class CustomCounter : CounterAction
{
    GameObject obj;
    protected override void Start()
    {
        base.Start();
        obj = GameObject.FindWithTag("Counter");
        CustomCounter action = obj.GetComponent<CustomCounter>();
    }
}
