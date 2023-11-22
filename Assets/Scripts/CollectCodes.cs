using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCodes : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            other.gameObject.transform.position = transform.position + Vector3.forward;
            other.gameObject.AddComponent<CollectCodes>();
            Destroy(gameObject.GetComponent<CollectCodes>());
            other.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.AddComponent<NodeMovement>();
            other.gameObject.GetComponent<NodeMovement>().connectedNode = transform;
            other.gameObject.tag = "Collected";
        }
    }
}
