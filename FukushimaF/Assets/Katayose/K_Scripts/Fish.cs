﻿using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour
{
	private bool  jumpFlag = true ;

	public  float thrust_UP ;
	public  float thrust_LEFT ;
	
	void Update ()
	{
		if( jumpFlag )
		{
			GetComponent<Rigidbody2D>().AddForce(Vector2.up   * thrust_UP) ;
			GetComponent<Rigidbody2D>().AddForce(Vector2.left * thrust_LEFT) ;
			
			//float angle = Mathf.Atan2( thrust_UP, thrust_LEFT ) * Mathf.Rad2Deg;

			jumpFlag = false ;
		}
	}
}