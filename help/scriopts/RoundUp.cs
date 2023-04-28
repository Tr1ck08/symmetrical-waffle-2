using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RoundUp : MonoBehaviour
{
    public Text roundnum;
    public int currentRound = 0;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            currentRound = currentRound + 1;
        }
    }

}
