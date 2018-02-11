using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PressAnyKey : MonoBehaviour
{
  void Update()
    {
      if(Input.anyKeyDown)
        {
          SceneManager.LoadScene("Scene");
        }
    }
}
