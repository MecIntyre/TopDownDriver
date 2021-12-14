using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFlollow;
    void LateUpdate()
    {
        transform.position = thingToFlollow.transform.position + new Vector3 (0, 0, -10);
    }
}
