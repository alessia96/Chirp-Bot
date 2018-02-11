using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class RobotCollision : MonoBehaviour
{
  private bool approach = false;
  public GameObject popUp;
  public GameObject chirp; 
  public GameObject happensNext = null;

  void Start()
    {
      popUp.SetActive(false);
    }

  void Update()
    {
      if(approach)
        {
          popUp.SetActive(true);
          if(Input.GetKeyDown(KeyCode.E))
              {
              chirp.SetActive(true);
              happensNext.SetActive(true);
              StartCoroutine(Wait(3));
              }
        } else {
          popUp.SetActive(false);
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

  IEnumerator Wait(int toWait)
    {
      yield return new WaitForSeconds(toWait);
      chirp.SetActive(false);
    }
}
