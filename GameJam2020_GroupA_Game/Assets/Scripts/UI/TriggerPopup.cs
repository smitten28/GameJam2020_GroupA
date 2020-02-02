using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPopup : MonoBehaviour
{
    private GUIPopUp popup;
    private string tooltipText;
    private bool isFullyRepaired;
    private bool isLadder;
    private void Awake()
    {
        popup = GetComponent<GUIPopUp>();
    }

    // Start is called before the first frame update
    void Start()
    {
        isFullyRepaired = false;
        isLadder = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !isLadder && isFullyRepaired)
        {
            tooltipText = "Press E to Upgrade This Room.";
            popup.setToolTip(tooltipText);
            popup.setShowTooltip(true);
        }
        else if(collision.gameObject.CompareTag("Player") && !isLadder && !isFullyRepaired)
        {
            tooltipText = "Press Spacebar to Repair This Room.";
            popup.setToolTip(tooltipText);
            popup.setShowTooltip(true);
        }
        else if(collision.gameObject.CompareTag("Player") && isLadder)
        {
            tooltipText = "Press Spacebar to Climb or Descend.";
            popup.setToolTip(tooltipText);
            popup.setShowTooltip(true); 
        }
    }
}
