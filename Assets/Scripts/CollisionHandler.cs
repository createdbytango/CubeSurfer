using UnityEngine;

public class CollisionHandler : MonoBehaviour {

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	public PlayerMovement movement;		
	void OnCollisionEnter(Collision other)
	{
		Debug.Log(other.collider.name);
		if(other.collider.tag=="Obstacle")
		{	
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}	
	}
}
