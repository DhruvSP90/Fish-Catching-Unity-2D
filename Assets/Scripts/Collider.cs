using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Collider : MonoBehaviour 
{
	public int score;
	
	[SerializeField]TextMeshProUGUI display;
	
	void OnTriggerEnter2D (Collider2D Collision) 
	{	
		if (Collision.gameObject.tag == "Fish") 
		{	
			score += 10;
			display.text = "Score : " + score;
			Destroy (Collision.gameObject);
        }

		if (Collision.gameObject.tag == "Bomb")
		{	
			score -= 10;
            display.text = "Score : " + score;
			Destroy (Collision.gameObject);
        }
	}
}