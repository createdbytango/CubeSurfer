using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float multi;
	public float jumpmulti;
	public Rigidbody rb;
	public bool isGrounded=true;
	public Vector3 jump; 
	public float jumpforce=10.0f;
	//public Collision other;
	
	private void Start() 
	{
		rb=GetComponent<Rigidbody>();
		jump=new Vector3(0.0f,5.0f,0.0f);
	}

	
	void OnCollisionStay()
	{
		isGrounded=true;
	}
	
	// Update is called once per frame
	void Update () {
		
		rb.AddForce(Input.GetAxis("Horizontal")*multi*Time.deltaTime,0f,0f,ForceMode.VelocityChange);
		rb.AddForce(0f,0f,Input.GetAxis("Vertical")*multi*Time.deltaTime,ForceMode.VelocityChange);
		
		if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			//rb.AddForce(0f,Input.GetAxis("Jump")*jumpmulti*Time.deltaTime,0f,ForceMode.Impulse);        
			rb.AddForce(jump*jumpforce,ForceMode.Impulse);
			isGrounded=false;
		}
		

		if(rb.position.y < -1f)
			FindObjectOfType<GameManager>().EndGame();

	}
}
