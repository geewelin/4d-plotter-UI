﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VRInputField : InputField
{

    public override void OnSelect(BaseEventData eventData)
    {
        Debug.Log("Overrides InputField.OnSelect");
        base.OnSelect(eventData);
        //ActivateInputField();
    }

    public override void OnDeselect(BaseEventData eventData)
    {
        Debug.Log("Overrides InputField.Deselect");
        //DeactivateInputField();
        //base.OnDeselect(eventData);
    }


}