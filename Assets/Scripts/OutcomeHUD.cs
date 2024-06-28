using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutcomeHUD : BaseOutcome
{
    public Text messageText;
    public string message;
   

    public override void Execute()
    {
        Debug.Log("Outcome HUD executed");

        // Instantiate itself
        GameObject instance = Instantiate(gameObject, Vector3.zero, Quaternion.identity);
        
        // Find the messageText component in the instance
        OutcomeHUD outcomeHUDInstance = instance.GetComponent<OutcomeHUD>();
        outcomeHUDInstance.messageText.text = message;
        
    }

}

