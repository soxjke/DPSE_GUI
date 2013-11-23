// 
// Net.cs
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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//using UnityEngine;

namespace Model
{
	public class Net
	{
		public String NetId;
		
		private readonly List<Node> _nodes;
		
		public IList<Node> Nodes
		{
		    get
		    {
		        return _nodes.AsReadOnly();
		    }
		}
		
		public Net (Node start, Node finish)
		{
			_nodes = new List<Node>(2);
			_nodes.Add(start);
			_nodes.Add(finish);
		}
		
		public Net (List<Node> nodes)
		{
			Debug.Assert(nodes.Count != 2, "The provided list of nodes in Net initializer should be exactly 2");
			_nodes = nodes;
		}
	}
}