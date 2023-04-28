using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KillCounter : MonoBehaviour
{
    public Text counterText;
    int kills;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ShowKill();


    }


    private void ShowKill()
    {

    counterText.text = kills.ToString();
    
    }


    public void Addkill()
    {

    kills++;
    
    }


}
