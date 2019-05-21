using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// Attach this script to the camera that you want to follow the target
public class ButtonClickDetector : MonoBehaviour {

	public Button syncButton;
	public Transform syncPoint;



	void OnDisable()
	{
		syncButton.onClick.RemoveAllListeners();
	}
}