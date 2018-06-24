﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class HostOrClient : MonoBehaviour {

	private NetworkManager manager;
	// Use this for initialization
	void Start () {
		manager = GetComponent<NetworkManager>();
		if(OnlineInit.option == 1){
			/*manager.serverBindToIP = true;
			manager.serverBindAddress = Network.player.ipAddress;*/
			manager.networkAddress =  Network.player.ipAddress;
			manager.StartHost();
			//manager.StartServer();

		}
		else
		{
			
			manager.networkAddress =  OnlineInit.ip;
			Debug.Log(OnlineInit.ip);
			manager.StartClient();
		}
		
	}
	
	
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
