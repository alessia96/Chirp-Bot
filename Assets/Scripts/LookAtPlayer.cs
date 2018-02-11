using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour
{
  void Update()
    {
      if(gameObject.activeSelf)
        {
          transform.LookAt(Camera.main.transform.position);
        }
    }
}
