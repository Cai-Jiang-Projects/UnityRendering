using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCreater : MonoBehaviour {

    public GameObject tree; 
	
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 
            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(tree, hit.point, transform.rotation); 
            }
        }
	}
}
