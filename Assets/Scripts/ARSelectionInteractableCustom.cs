using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ARSelectionInteractableCustom : ARSelectionInteractable
{
    //protected override ARSessionOrigin
    protected override void Awake(){
        base.Awake();
    }

    protected override bool CanStartManipulationForGesture(TapGesture gesture)
        {
            if (gesture.startPosition.IsPointOverUIObject())
            {
                return false;
            }

            if (gesture.targetObject.layer == 5)
            {
                return false;
            }

            // if (gesture.targetObject == null || gesture.targetObject.layer == 9)
            // {
            //     return true;
            // }

            return true;
            }
}
