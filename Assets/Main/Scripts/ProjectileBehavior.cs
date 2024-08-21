using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.forward * 3f * Time.deltaTime;
    }
}
