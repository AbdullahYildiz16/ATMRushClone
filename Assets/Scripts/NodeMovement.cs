using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform connectedNode;
    public float nodeSpeed = 20f;
    private void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, connectedNode.transform.position.x, nodeSpeed*Time.deltaTime),
            connectedNode.transform.position.y,
            connectedNode.position.z +0.5f);
    }
}
