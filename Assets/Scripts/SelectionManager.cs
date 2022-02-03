using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    GameObject selection;
    RingRotator ringRotator;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mp = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mp);
            RaycastHit hitSelection = new RaycastHit();
            bool hit = Physics.Raycast(ray, out hitSelection);

            if (hit)
            {
                if (hitSelection.transform.gameObject.tag == "Ring")
                {
                    selection = hitSelection.transform.gameObject;
                    ringRotator = hitSelection.transform.GetComponent<RingRotator>();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ringRotator.shouldRotate = !ringRotator.shouldRotate;
        }


    }



}
