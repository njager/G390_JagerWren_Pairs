using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DrawLine : MonoBehaviour
{
    //variables
    [SerializeField] Rigidbody leftPlayer;
    [SerializeField] Rigidbody rightPlayer;
    private LineRenderer lr;
    private Vector3 start;
    private Vector3 end;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        //finds and sets rigid body locations to the start and end Vector3 variables
        start = leftPlayer.transform.position;
        end = rightPlayer.transform.position;
        SetPosition();
    }

    //sets the line start and end positions
    void SetPosition()
    {
        start.y += 1;
        end.y += 1;
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);
    }
}
