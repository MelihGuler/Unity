using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraAyari : MonoBehaviour {
    private Vector3 mesafe;
    private GameObject top;
	void Start () {
        top = GameObject.Find("Top");
        mesafe = transform.position - top.transform.position;
	}
	
	
	void LateUpdate () {
        transform.position= top.transform.position+mesafe;
	}
}
