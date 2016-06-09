using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {

        offset = transform.position - player.transform.position;

	}
	
	// LateUpdate is called once per frame after everything else has been processed for that frame update. This allows us to know for sure that the payer has moved.
	void LateUpdate ()
    {

        transform.position = player.transform.position + offset;

	}
}
