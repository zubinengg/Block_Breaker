using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
static MusicPlayer instance = null;

	// Use this for initialization
	void Awake()
	{
		//Debug.Log(" Instanse ID awake " + GetInstanceID().ToString());
		if (instance!=null)
		{
			Destroy(gameObject);			
		}
		else
		{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);	
		}	
	}
	void Start () 
	{
		//Debug.Log(" Instanse ID Start " + GetInstanceID().ToString());
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
