using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ChangeOnGrab : MonoBehaviour
{
    public GameObject SphereHand;
    public XRRayInteractor interactor;

    private void OnEnable()
    {
        interactor.selectEntered.AddListener(PickUpObject);
        interactor.selectExited.AddListener(DropObject); 
    }
    
    private void OnDisable() {
        interactor.selectEntered.RemoveListener(PickUpObject);
        interactor.selectExited.RemoveListener(DropObject);
    }

    public void PickUpObject(SelectEnterEventArgs args)
    {
        //SphereHand.SetActive(false);
        MeshRenderer grabbedMesh = args.interactableObject.transform.GetComponent<MeshRenderer>();
        grabbedMesh.material.color = Color.white;
    }
    
    public void DropObject(SelectExitEventArgs args)
    {
        //SphereHand.SetActive(true);
        MeshRenderer grabbedMesh = args.interactableObject.transform.GetComponent<MeshRenderer>();
        grabbedMesh.material.color = Color.gray;
    }

}
