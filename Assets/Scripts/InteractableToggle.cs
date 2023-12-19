// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// using UnityEngine.XR.Interaction.Toolkit.AR;

// public class InteractableToggle : MonoBehaviour
// {
//     private ARPlacementInteractable placementInteractable;
//     // Start is called before the first frame update
//     void Start()
//     {
//         placementInteractable = this.GetComponent<ARPlacementInteractable>();
//         ARObjectPlacedEvent aRObjectPlacedEvent = placementInteractable.objectPlaced;
//         aRObjectPlacedEvent.AddListener(ObjectPlaced);
//         // ARObjectPlacementEvent placedEvent = placementInteractable.objectPlaced;
//         // placedEvent.AddListener(ObjectPlaced);

//     }
 
 
//     private void ObjectPlaced(ARPlacementInteractable p, GameObject q)
//     {
//         placementInteractable.placementPrefab = null;
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class InteractableToggle : MonoBehaviour
{
    private ARPlacementInteractable placementInteractable;

    // Start is called before the first frame update
    void Start()
    {
        placementInteractable = GetComponent<ARPlacementInteractable>();
        if (placementInteractable != null)
        {
            // placementInteractable.enabled = false;
            placementInteractable.objectPlaced.AddListener(ObjectPlaced);
        }
        else
        {
            Debug.LogError("ARPlacementInteractable component not found on the GameObject.");
        }
    }

    // Correct the signature to match the UnityAction<ARObjectPlacementEventArgs> delegate
    private void ObjectPlaced(ARObjectPlacementEventArgs args)
    {
        // You can disable the placementInteractable here if you don't want further placements
        placementInteractable.enabled = false;

        // Or if you want to change the prefab for the next placement, you can do so here
        // placementInteractable.placementPrefab = [Your Next Prefab];
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic (if necessary)
    }
}
