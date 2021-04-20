using UnityEngine;
using System.Collections;

public class CameraAspect : MonoBehaviour 
{
	public GameObject[] gm;

	void Start ()
	{
		Camera.main.aspect = 800/1280;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		Time.timeScale = 1;
    }
		
}
