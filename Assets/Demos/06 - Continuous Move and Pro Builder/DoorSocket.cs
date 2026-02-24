using UnityEngine;

public class DoorSocket : MonoBehaviour
{
    public MoveToTarget thingToMove;

    public void OpenDoor()
    {
        thingToMove.MoveTo(new Vector3(0f, 3f, 0f));
    }

    public void CloseDoor()
    {
        thingToMove.MoveBack();
    }
}
