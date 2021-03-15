using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class kill_mission_gameobject : MonoBehaviour
{
    public GameObject takipEdilecek;



    // Update is called once per frame
    void Update()
    {
	if(takipEdilecek)
        this.transform.position = takipEdilecek.transform.position;
    }
}
