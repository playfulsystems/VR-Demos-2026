using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    float time;
    Vector3 targetPos;
    Vector3 originalPos;
    Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPos = transform.position;
        startPos = transform.localPosition;
        targetPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(startPos, targetPos, time);
        time += Time.deltaTime;
    }

    public void MoveTo(Vector3 newTargetPos)
    {
        startPos = transform.position;
        targetPos = newTargetPos;
        time = 0;
    }

    public void MoveBack()
    {
        MoveTo(originalPos);
    }
}
