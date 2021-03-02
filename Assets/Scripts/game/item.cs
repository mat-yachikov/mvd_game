using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class item : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private GameObject textImage;
    public Sprite text_sprite;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnMouseDown()
    //{
    //    Debug.Log("click on cake");
    //}

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        //Output the name of the GameObject that is being clicked
        Debug.Log(name + " Game Object Click in Progress");
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            textImage = GameObject.Find("textImage");
            textImage.GetComponent<Image>().enabled = true;
            textImage.GetComponent<Image>().sprite = text_sprite;
            GetComponent<Image>().enabled = false;

            Debug.Log(name + " No longer being clicked");
        }        
    }

}
