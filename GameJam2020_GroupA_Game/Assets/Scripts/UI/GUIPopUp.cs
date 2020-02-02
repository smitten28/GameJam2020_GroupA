using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class GUIPopUp : MonoBehaviour
{
    //[SerializeField] private GUIContent content;
    private string tooltip;
    [SerializeField] private float xOffset;
    [SerializeField] private float yOffset;
    //[SerializeField] private  message;
    [SerializeField] private GameObject spawnPos;
    

    //private Vector2 objectPosition;
    private bool showTooltip;
    //private bool isFullyRepaired;


    // Start is called before the first frame update
    void Start()
    {
        //yOffset = -(gameObject.transform.position.y / 2);
        showTooltip = false;
        //content.text = tooltip;
    }

    private void OnGUI()
    {
        if(showTooltip)
        {
            //message = tooltip;
            //Instantiate(message);
            //message.transform.position = new Vector2(spawnPos.transform.position.x, spawnPos.transform.position.y + 2);
            Debug.Log("Create popup");
            //box = GUILayoutUtility.GetRect(content, GUI.skin.box);
            //GUI.Box(new Rect(objectPosition.x + xOffset, Screen.height - objectPosition.y, box.width, box.height), content);
        }
    }
    public bool getShowTooltip()
    {
        return showTooltip;
    }
    public void setShowTooltip(bool status)
    {
        showTooltip = status;
    }
    public void setToolTip(string tt)
    {
        tt = tooltip;
    }

}
