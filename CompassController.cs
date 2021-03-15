using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class CompassController : MonoBehaviour
{

    public GameObject target;
    private Vector3 targetPosition;
    private RectTransform pointerRectTransform;

    private void Awake()
    {
        
       // targetPosition = new Vector3(-18, 25);
        pointerRectTransform = transform.Find("Pointer").GetComponent<RectTransform>();

    }

    private void Update()
    {
        if (target == true)
        {
            Vector3 targetPosition = (target.transform.position);
            Vector3 toPosition = targetPosition;
            Vector3 fromPosition = Camera.main.transform.position;
            fromPosition.z = 0f;
            Vector3 dir = (toPosition - fromPosition).normalized;
            float angle = UtilsClass.GetAngleFromVectorFloat(dir);
            pointerRectTransform.localEulerAngles = new Vector3(0, 0, angle);
        }

            
    }

}

