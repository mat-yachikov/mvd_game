using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class exit_button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    void Start()
    {

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

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        Application.Quit();
    }

}
