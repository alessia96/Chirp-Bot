using UnityEngine;
using System.Collections;

public class PressE : MonoBehaviour
{
  public GameObject textRobot;
  public GameObject character;
  public GameObject robot;
  public GameObject nextText;
  public GameObject camera;
  public GameObject audio;

  void Update()
    {
      if(textRobot.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
          camera.SetActive(true);
          character.SetActive(false);
          textRobot.SetActive(false);
          robot.SetActive(false);
          audio.SetActive(true);
          nextText.SetActive(true);
        }
    }
}
