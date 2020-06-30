using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFocus : MonoBehaviour
{
	public Transform Player;
    
	void LateUpdate()
	{
		transform.position = new Vector3(Player.transform.position.x, transform.position.y, -10f);
	}
}
