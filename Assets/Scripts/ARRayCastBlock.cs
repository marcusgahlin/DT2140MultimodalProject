using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

// [[RequireComponent(typeof(ARRaycastManager))]]

public class ARRayCastBlock : ARPlacementInteractable
{
//     [SerializeField]

//     private GameObject placedPrefab;

//     [SerializeField]

//     private GameObject muteButton;

//     [SerializeField]

//     private GameObject placedPrefab;
//     // Start is called before the first frame update
//     void Start()
//     {

//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(Input.touchCount > 0)
//         {
//             Touch touch = Input.GetTouch(0);

//             if(touch.phase = TouchPhase.Began)
//             {
//                 var touchPos = touch.position;
//                 bool isOverUI = touchPos.IsPointOverUIObject(); //custom method

//                 if(isOverUI)
//                 {
//                     // Do nothing
//                 }
//                 if(!isOverUI && arRaycastManager.Raycast(touchPos, hits, UnityEngine.XR.ARSubsystems.TrackableType))
//                 {
//                     //var hitPose = hits[0].pose;
//                     //Instantiate(pla)
//                 }
//             }
//         }
//     }

    protected override bool CanStartManipulationForGesture(TapGesture gesture)
    {
        // if (gesture.startPosition.IsPointOverUIObject())
        // {
        //     return false;
        // }
        // if (gesture.targetObject == null)
        // {
        //     return true;
        // }
        // return false;
        // if (gesture.targetObject != null && gesture.targetObject.layer == 5)
        // {
        //     return false;
        // }

        // gesture.targetObject == null gäller då vi trycker på ett fält
        if (gesture.targetObject != null && gesture.targetObject.layer == 5)
        {
             return false;
        }
        return true;
        // return gesture.targetObject == null;
    }
}
