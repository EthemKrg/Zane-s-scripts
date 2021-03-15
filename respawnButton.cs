using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawnButton : MonoBehaviour
{
    public GameObject DeadPanel;

    public FloatValue konteynir;
    public FloatValue respawnCan;

    public StringValue Mainsahne;
    

    // Start is called before the first frame update
    void Start()
    {
        DeadPanel.SetActive(false);


    }

 

    public void deadPanel()
    {
        DeadPanel.gameObject.SetActive(true);
    }


    public void respawn()
    {
        SceneManager.LoadScene(Mainsahne.RuntimeValue);
        respawnCan.RuntimeValue = (konteynir.RuntimeValue)*2;
    }
}
