﻿using UnityEngine;
using System.Collections;

public class CameraOrbit : MonoBehaviour {

	GameObject mainPlayer;

  void Start () {
    mainPlayer = GameAttributes.mainPlayer;
  }
	void Update () {
	  transform.position = new Vector3(mainPlayer.transform.position.x, mainPlayer.transform.position.y + 1f, mainPlayer.transform.position.z);
	}
}
