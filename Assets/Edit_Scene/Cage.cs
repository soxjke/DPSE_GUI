// 
// Cage.cs
//  
// Author:
//       Petro Korienev <korenevpetro@gmail.com>
// 
// Copyright (c) 2013 Petro Korienev
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using UnityEngine;
using System.Collections;

public class Cage : MonoBehaviour {
	
	private static Material lineMaterial;
	
	private const int lineCount = 9;
	
	private const float lineDistance = 5.0f;
	
	private const float delta = 1.0f;
	
	private static Color lineColor = new Color(0.8f,0.1f,0.1f,0.5f);
	
	void OnGUI ()
	{
		
	}
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		
	}
	
	static void CreateLineMaterial() 
	{
		if( !lineMaterial ) 
		{
			lineMaterial = new Material( "Shader \"Lines/Colored Blended\" {" +
				"SubShader { Pass { " +
				"    Blend SrcAlpha OneMinusSrcAlpha " +
				"    ZWrite Off Cull Off Fog { Mode Off } " +
				"    BindChannels {" +
				"      Bind \"vertex\", vertex Bind \"color\", color }" +
				"} } }" );
			lineMaterial.hideFlags = HideFlags.HideAndDontSave;
			lineMaterial.shader.hideFlags = HideFlags.HideAndDontSave;
		}
	}
	
	void OnPostRender() 
	{
		CreateLineMaterial();		
		
		GL.PushMatrix();
		
		lineMaterial.SetPass(0);
		
		float startPos 	= - lineDistance * (lineCount / 2);
		float endPos	= lineDistance * (lineCount / 2);
		
		for (int i = 0; i < lineCount; i++)
		{
/*			
			for (int j = 0; j < lineCount; j++)
			{
*/			
				GL.Begin(GL.LINES);						
				GL.Color(lineColor);
				GL.Vertex3(startPos + i * lineDistance, 0/*startPos + j * lineDistance*/, startPos - lineDistance);
				GL.Vertex3(startPos + i * lineDistance, 0/*startPos + j * lineDistance*/, endPos + lineDistance);
				GL.End();
				
				GL.Begin(GL.LINES);						
				GL.Color(lineColor);
				GL.Vertex3(startPos - lineDistance, 0/*startPos + j * lineDistance*/, startPos + i * lineDistance);
				GL.Vertex3(endPos + lineDistance, 0/*startPos + j * lineDistance*/, startPos + i * lineDistance);
				GL.End();			
/*			
			}
*/		
/*			
			for (int k = 0; k < lineCount; k++)
			{
				GL.Begin(GL.LINES);						
				GL.Color(vertLineColor);
				GL.Vertex3(startPos + k * lineDistance, startPos, startPos + i * lineDistance);
				GL.Vertex3(startPos + k * lineDistance, endPos, startPos + i * lineDistance);
				GL.End();							
			}
*/			
		}	
		
		GL.Begin(GL.LINES);						
		GL.Color(lineColor);
		GL.Vertex3(0, startPos, 0);
		GL.Vertex3(0, endPos, 0);
		GL.End();							

			
		GL.PopMatrix();
	}
}
