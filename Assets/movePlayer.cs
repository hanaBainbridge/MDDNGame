using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {
	public float speed;

	public float upSpeed;

	public GameObject player1;
	public GameObject player2;

	void Start(){
		speed = 10;
		upSpeed = 15;
	}

	// Update is called once per frame
	void FixedUpdate () {
		// player one movement
		// move to the right
		if(Input.GetKey(KeyCode.G)){
			player1.transform.position+= new Vector3(speed *Time.deltaTime,0.0f,0.0f);
		}
		//move to the left
		if(Input.GetKey(KeyCode.D)){
			player1.transform.position-= new Vector3(speed *Time.deltaTime,0.0f,0.0f);
		}
		//jump move
		if(Input.GetKey(KeyCode.R)){
			player1.transform.position+= new Vector3(0.0f,upSpeed *Time.deltaTime,0.0f);
		}


		// player two movement	
		// move to the right
		if(Input.GetKey(KeyCode.L)){
			player2.transform.position+= new Vector3(speed *Time.deltaTime,0.0f,0.0f);
		}
		//move to the left
		if(Input.GetKey(KeyCode.LeftArrow)){
			player2.transform.position-= new Vector3(speed *Time.deltaTime,0.0f,0.0f);
		}
		//jump move
		if(Input.GetKey(KeyCode.U)){
			player2.transform.position+= new Vector3(0.0f,upSpeed *Time.deltaTime,0.0f);
		}
	}
	public void RestartGame(){
		player2.transform.position= new Vector3(17.5f,1.84f,0.0f);
		player1.transform.position= new Vector3(-19.2f,-2.04f,0.0f);	
	}

}
