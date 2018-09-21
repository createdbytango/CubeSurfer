using UnityEngine;

public class CameraFolow : MonoBehaviour {
	public Transform player;
	public Vector3 v;
	// Update is called once per frame
	void Update () {
		transform.position=player.position + v;
	}
}
