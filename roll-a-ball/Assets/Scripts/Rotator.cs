﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {


	void Update () {
        this.transform.Rotate(new Vector3(45, 45, 45)*Time.deltaTime);
	}
}
