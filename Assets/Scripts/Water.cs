using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    void  FixedUpdate()
    {
        transform.Translate(new Vector3(-0.03f, 0f, 0f));
    }
}
