using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit;

public class HideOnGrab : MonoBehaviour
{
    public GameObject SphereHand;
    public XRRayInteractor interactor;

    private void OnEnable()
    {
        interactor.selectEntered.AddListener(PickUpObject);
        interactor.selectExited.AddListener(DropObject);
    }

    private void OnDisable()
    {
        interactor.selectEntered.RemoveListener(PickUpObject);
        interactor.selectExited.RemoveListener(DropObject);
    }

    public void PickUpObject(SelectEnterEventArgs args)
    {
        SphereHand.SetActive(false);
    }

    public void DropObject(SelectExitEventArgs args)
    {
        SphereHand.SetActive(true);
    }
}
