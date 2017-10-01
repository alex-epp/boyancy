using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParticles : MonoBehaviour {

	public Vector3 min;
	public Vector3 max;

	public GameObject water;
	public int numWater = 10;
	public float waterSpeed = 1;
	public GameObject air;
	public int numAir = 10;
	public float airSpeed = 10;

	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < numWater; ++i)
		{
			GameObject p = Instantiate (water, new Vector3 (Random.Range (min.x, max.x), Random.Range (min.y, max.y), Random.Range (min.z, max.z)), new Quaternion ());
			Vector3 velocity = new Vector3 (Random.Range (-1f, 1f), Random.Range (-1f, 1f), Random.Range (-1f, 1f));
			velocity.Normalize ();
			velocity.Scale (new Vector3 (waterSpeed, waterSpeed, waterSpeed));
			p.GetComponent<Rigidbody> ().velocity = velocity;
		}
		for (int i = 0; i < numAir; ++i)
		{
			GameObject p = Instantiate (air, new Vector3 (Random.Range (min.x, max.x), Random.Range (min.y, max.y), Random.Range (min.z, max.z)), new Quaternion ());
			Vector3 velocity = new Vector3 (Random.Range (-1f, 1f), Random.Range (-1f, 1f), Random.Range (-1f, 1f));
			velocity.Normalize ();
			velocity.Scale (new Vector3 (airSpeed, airSpeed, airSpeed));
			p.GetComponent<Rigidbody> ().velocity = velocity;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
