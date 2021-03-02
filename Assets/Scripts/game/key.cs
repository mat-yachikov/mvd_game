using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class key : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private GameObject lock1;
    private Sprite key_sprite;

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

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (GameObject.Find("textImage").GetComponent<textImageScr>().getNum() >= 7)
        {
            lock1 = GameObject.Find("lock");
            lock1.GetComponent<Image>().enabled = false;
            key_sprite = Resources.Load<Sprite>("Sprites/key/empty");
            GetComponent<Image>().sprite = key_sprite;
        }
    }

}
