using System;
using System.Collections.Generic;


[Serializable]
public class OpaqueBehavior : Behavior
{
	 
	private string language;
	public string Language
	{
		get{return language;}
		set{language = value;}
	}
	
	 
	private string body;
	public string Body
	{
		get{return body;}
		set{body = value;}
	}
	
	public OpaqueBehavior(string name) : base(name)
	{
	}
	
	public Class _lookForOperation(Class cl)
	{
		//Debug.Log("----- Trying to create opaque behavior : " + cl.name + " : " + body + " : " + cl.Parents.Count);
		if (cl.Operations.ContainsKey(body))
		{
			return cl;
		}
		else if (cl.Parents.Count != 0)
		{
			
			return _lookForOperation((Class)(cl.Parents[0]));
		}
		else 
		{
			System.Console.WriteLine ("Ca va planter.....");
			return null;
		}
	}
	
	public override BehaviorExecution createBehaviorExecution (InstanceSpecification host, Dictionary<string,ValueSpecification> p, bool sync)
	{
		Class cl = (Class)(host.Classifier);
		
		
		Class ocl = _lookForOperation(cl);
		
		if (ocl == null) return null;
		
		string typeName = ocl.name+"_"+body;
		BehaviorExecution be = BehaviorScheduler.Instance.InstanciateOpaqueBehavior(this,typeName,host,p);
		return be;
	}
}

