using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	public float speed=0.5f;
	public GameObject ground;
	private int count=0;
	public GameObject obstacles;
    private bool isJump=false;
    public Rigidbody2D body;
    private float pos=24f;
    // Update is called once per frame
    void Awake() {
    	body=this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
    	this.transform.position=new Vector2(transform.position.x+speed*Time.deltaTime,this.transform.position.y); 
    	if(this.transform.position.x > count * 51f) {
    		count+=1;
    		pos+=51f;
    		Object.Instantiate(ground, new Vector3(pos,-4.47f,0f),Quaternion.identity);
    	}
 		if (Input.GetKeyDown(KeyCode.Space) && !isJump) {
    		body.AddForce(transform.up*7f,ForceMode2D.Impulse);
    		isJump=true;
    	}
    }

	void OnCollisionEnter2D(Collision2D col) {
	    if(col.gameObject.tag == "ground")
	    {
	        isJump = false;
	    }
	    if(col.gameObject.tag=="obstacles") {
	    	SceneManager.LoadScene("SampleScene");
	    }
	}
}

