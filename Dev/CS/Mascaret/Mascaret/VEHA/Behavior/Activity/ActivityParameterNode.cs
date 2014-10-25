using System;
using System.Collections.Generic;


[Serializable]
public class ActivityParameterNode : ObjectNode
{
	 
	private Parameter parameter;
	public Parameter Parameter
	{
		get{return parameter;}
		set{parameter = value;}
	}
	
	public ActivityParameterNode(string name) : base(name)
	{
		Kind = "parameter";
	}
}
