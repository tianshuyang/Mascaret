using System;
using System.Collections.Generic;

[Serializable]
public class Mailbox
{
	 
	private List<ACLMessage> messagesQueue;
	public List<ACLMessage> MessagesQueue
	{
		get{return messagesQueue;}
		set{messagesQueue=value;}
	}
	
	 
	private List<ACLMessage> messagesChecked;
	public List<ACLMessage> MessagesChecked
	{
		get{return messagesChecked;}
		set{messagesChecked=value;}
	}
	
	 
	private List<ACLMessage> messagesSent;
	public List<ACLMessage> MessagesSent
	{
		get{return messagesSent;}
		set{messagesSent=value;}
	}
		
	
	public void postMessage(ACLMessage message)
	{
		messagesQueue.Add(message);
	}
	
	public ACLMessage check()
	{
		ACLMessage msg=null;
		
		if(messagesQueue.Count!=0)
		{
			msg = messagesQueue[0];
			messagesQueue.RemoveRange(0,1);
			messagesChecked.Add(msg);
		}
		
		return msg;
	}
	
	public void send(ACLMessage message)
	{
		messagesSent.Add(message);
	}
}

