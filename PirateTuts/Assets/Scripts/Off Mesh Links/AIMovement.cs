using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour {

    // Use this for initialization

    private NavMeshAgent agent;
    public Transform location;

    


    
	void Start () {

        agent = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray))
            {
                Debug.Log("Get position " + Input.mousePosition);
                agent.SetDestination(Input.mousePosition);
            }
        }

        agent.SetDestination(location.position);

	}
}
