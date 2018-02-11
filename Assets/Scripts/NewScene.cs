using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
  private bool approach = false;
  public string chooseScene;

  void Update()
    {
      if(approach)
        {
          if(Input.GetKeyDown(KeyCode.E))
              {
              SceneManager.LoadScene(chooseScene);
              }
        }
	}

  void OnTriggerEnter(Collider coll)
    {
      if(coll.tag == "Player")
        {
          approach = true;
        }
    }

  void OnTriggerExit(Collider coll)
    {
      if(coll.tag == "Player")
        {
          approach = false;
        }
    }
}
