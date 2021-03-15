using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ViewportScroller : MonoBehaviour
{

    public RectTransform scroll;
    Vector3 pozisyon;
    private int deger;
     
    public void Scroller()
    {
        Canvas.ForceUpdateCanvases();
        deger = (int)(QuestManager.order);

        pozisyon.y = (deger*50.0f);
      
        Vector3 temp = new Vector3(0f, pozisyon.y, 0f);

        scroll.anchoredPosition = temp;


    }

}
