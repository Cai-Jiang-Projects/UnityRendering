/*
 * Prints out a different tree based on left or right mouse click. 
 * 
 * Author: Gavin Cai
 * Date Last Edited: 27 June 2017
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCreater : MonoBehaviour {

    public GameObject sycamoreTree;
    public GameObject tree2; 
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 
            if (Physics.Raycast(ray, out hit)) {
                Instantiate(sycamoreTree, hit.point, transform.rotation); 
            }
        }
        if (Input.GetMouseButtonDown(1)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                Instantiate(tree2, hit.point, transform.rotation);
            }
        }
	}
}
