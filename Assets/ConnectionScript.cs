using UnityEngine;
using System.Collections;

using MLAPI;
using UnityEngine.UI;

public class ConnectionScript : MonoBehaviour
{
    public void StartServer() { NetworkingManager.Singleton.StartServer(); }
    public void Connect() {
        GetComponent<LiteNetLibTransport.LiteNetLibTransport>().Address = GameObject.Find("InputField").GetComponent<InputField>().text;
        NetworkingManager.Singleton.StartClient(); }
    public void Quit() { Application.Quit(); }
}
