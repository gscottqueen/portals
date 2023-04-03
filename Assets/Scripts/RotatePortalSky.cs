using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePortalSky : MonoBehaviour
{
    void Update()
    {
      transform.Rotate(10 * Time.deltaTime, 5 * Time.deltaTime, 0);
    }
}
