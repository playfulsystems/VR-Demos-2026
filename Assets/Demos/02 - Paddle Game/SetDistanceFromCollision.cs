using TMPro;
using UnityEngine;

public class SetDistanceFromCollision : MonoBehaviour
{
    public TMP_Text DistanceText;
    public GameObject sign;
    float furthestDistance = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ball") return;

        float distance = Vector3.Distance(Vector3.zero, collision.GetContact(0).point);
        if (distance < 1) return;

        // for the smaller signs on land
        GameObject newSign = Instantiate(sign);
        newSign.transform.position = collision.GetContact(0).point + new Vector3(0,0.4f,0);
        newSign.GetComponentInChildren<TMP_Text>().text = distance.ToString("#.00");

        // for the big sign
        if (distance > furthestDistance)
        {
            DistanceText.text = "Best: " + distance.ToString("#.00");
            furthestDistance = distance;
        }
    }
}
