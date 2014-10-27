﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mascaret;



public class UnityShapeSpecification : ShapeSpecification {
	

	public GameObject entityGO;
	public GameObject EntityGO
	{
		get{return entityGO;}
		set{entityGO = value;}
	}

	public UnityShapeSpecification(string name) : base(name)
	{
	}

	public UnityShapeSpecification(string name, string url, bool movable,bool recursive, string shader) : base(name, url, movable, recursive, shader)
		
	{
		entityGO = GameObject.Find(url);
		if (entityGO != null)
		{
			EntityGo ego = (EntityGo)entityGO.GetComponent("EntityGo");
			if (ego == null) 
			{
				entityGO.AddComponent<EntityGo>();
				ego = (EntityGo)entityGO.GetComponent("EntityGo");
			}
			else Debug.Log(" Already has EntityGO Component");
		}
		else 
			Debug.Log (" Game Object : " + url + " not found");
	}
	
	//Default parameters movable=true, recursive =false, shader=""
	public UnityShapeSpecification(string name, List<double> distances,List<string> urls, bool movable,bool recursive, string shader) : base(name, distances, urls, movable, recursive, shader)
		
	{

	}

	public override void setVisibility(bool v){}
	public override bool getVisibility(){ return true;}
	
	public override void setScale(Mascaret.Vector3 scale){}
	public override Mascaret.Vector3 getScale(){return null;}
	
	
	public override void setEntity(Entity entity)
	{
		EntityGo ego = null;
		if (entityGO != null)
			ego = (EntityGo)entityGO.GetComponent("EntityGo");
		if (ego != null) ego.entity = entity;
	}
	public override Entity getEntity()
	{
		EntityGo ego = (EntityGo)entityGO.GetComponent("EntityGo");
		return ego.entity;
	}

	public override double prepareSpeak(string text)
	{

		return 1;
	}

	public override bool speak(string text)
	{

		return true;
	}
	
	// --- Shape Modifier Operations ---
	public override Mascaret.Color getColor(){return null;}
	public override void setColor(Mascaret.Color color){}
	public override void setTransparent(Mascaret.Color color){}
	public override void growUp(float percent){}
	public override bool restaureColor(Mascaret.Color color){return false;}
	public override bool restaureShape(){return false;}
}