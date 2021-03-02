using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class textImageScr : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private GameObject key;
    private Sprite key_sprite;
    private static int num;

    // Start is called before the first frame update
    void Start()
    {
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        //Output the name of the GameObject that is being clicked
        Debug.Log(name + " Game Object Click in Progress");
    }

    public int getNum()
    {
        return num;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {           
            if (num < 7)
            {
                GetComponent<Image>().enabled = false;
                key = GameObject.Find("key");
                num++;
                key_sprite = Resources.Load<Sprite>("Sprites/key/" + num.ToString());
                key.GetComponent<Image>().sprite = key_sprite;
            }
        }
        Debug.Log(num);
    }

}
