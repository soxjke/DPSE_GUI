using UnityEngine;
using System.Collections;

public class Cage : MonoBehaviour {
	
	public Material mat;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {	
		
	}
	
	void OnPostRender() 
	{
		GL.PushMatrix();
		mat.SetPass(0);
		GL.LoadIdentity();		
		GL.Begin(GL.LINES);
		GL.Color(Color.red);
		GL.Vertex(new Vector3(0, 0, 10));
		GL.Vertex(new Vector3(10, 10, 10));
		GL.End();
		GL.PopMatrix();
		Debug.DrawLine(new Vector3(0, 0, 10), new Vector3(10, 10, 10), Color.red);
	}
}
