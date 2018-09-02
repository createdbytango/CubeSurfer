using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float multi;
	public float jumpmulti;
	public Rigidbody rb;
	//public Collision other;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce(Input.GetAxis("Horizontal")*multi*Time.deltaTime,0f,0f,ForceMode.VelocityChange);
		rb.AddForce(0f,0f,Input.GetAxis("Vertical")*multi*Time.deltaTime,ForceMode.VelocityChange);
		rb.AddForce(0f,Input.GetAxis("Jump")*jumpmulti*Time.deltaTime,0f,ForceMode.Impulse);        
	}
}
