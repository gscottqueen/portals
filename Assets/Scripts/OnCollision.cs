using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class OnCollision : MonoBehaviour
{
  private GameObject[] InteriorWalls;

  private void Start()
  {
    InteriorWalls = GameObject.FindGameObjectsWithTag("InteriorWall");
    foreach (GameObject wall in InteriorWalls)
    {
      wall.SetActive(!wall.activeInHierarchy);
    }
  }
  void OnTriggerEnter(Collider other)
  {
    Debug.Log(other.name);
    if (other.gameObject.CompareTag("MainCamera"))
    {
      Debug.Log(other.tag);
      foreach (GameObject wall in InteriorWalls)
      {
        Debug.Log(wall);
        wall.SetActive(!wall.activeInHierarchy);
      }
    }
  }
}
