using UnityEngine;
using System.Collections;

public class RandomSpawner : MonoBehaviour
{
	public GameObject XRange;	
	public float Repeat, Delay;
    public GameObject[] items;

    void Start () 
	{
		InvokeRepeating ("Spawn", Delay, Repeat);
    }

	void Spawn () 
	{
		Vector2 pos = new Vector3 (Random.Range (gameObject.transform.position.x, XRange.transform.position.x), gameObject.transform.position.y);
		Instantiate (items [Random.Range (0, items.Length)], pos, gameObject.transform.rotation);
	}
} 