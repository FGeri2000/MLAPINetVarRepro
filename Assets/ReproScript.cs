using UnityEngine;
using System.Collections;
using MLAPI;
using MLAPI.NetworkedVar;

public class ReproScript : NetworkedBehaviour
{
    //Using generic to illustrate problem scope
    NetworkedVar<Vector2> input;

    private void Start()
    {
        input = new NetworkedVar<Vector2>(Vector2.zero);
    }
    private void Update()
    {
        //Assign value to the NetworkedVar on the client
        if (IsOwner) input.Value = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //Display information about the NetworkedVar
        GameObject.Find("Display").GetComponent<UnityEngine.UI.Text>().text = 
            string.Format("owner: {0}{4}value: {1}{4}dirty: {2}{4}last synced time: {3}",
            IsOwner,
            input.Value,
            input.isDirty,
            input.LastSyncedTime,
            System.Environment.NewLine);
    }
}
