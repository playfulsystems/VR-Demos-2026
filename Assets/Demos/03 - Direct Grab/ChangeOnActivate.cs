using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ChangeOnActivate : MonoBehaviour
{
    public GameObject block;
    public XRGrabInteractable interactable;

    Color defaultColor;
    Material material;
    Vector3 defaultScale;

    void OnEnable()
    {
        interactable.activated.AddListener(OnActivate);
        interactable.deactivated.AddListener(OnDeactivate);

        material = block.GetComponent<MeshRenderer>().material;
        defaultColor = material.color;
        defaultScale = block.transform.localScale;
    }

    // Update is called once per frame
    void OnDisable()
    {
        interactable.activated.RemoveListener(OnActivate);
        interactable.deactivated.RemoveListener(OnDeactivate);
    }

    void OnActivate(ActivateEventArgs args)
    {
        material.color = Color.green;
        float sc = 2f;
        block.transform.localScale = new Vector3(sc, sc, sc);
    }

    void OnDeactivate(DeactivateEventArgs args)
    {
        material.color = defaultColor;
        block.transform.localScale = defaultScale;
    }
}
