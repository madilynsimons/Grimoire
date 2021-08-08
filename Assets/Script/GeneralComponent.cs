using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GeneralComponent : MonoBehaviour
{
    private BoardComponent m_boardComponent;
    
    private void Start()
    {
        m_boardComponent = GameObject.FindGameObjectWithTag("Board").GetComponent<BoardComponent>();
        
        if (gameObject.CompareTag("GeneralP1"))
        {
            CardSpot = m_boardComponent.GeneralP1Default;
        }
        else if (gameObject.CompareTag("GeneralP2"))
        {
            CardSpot = m_boardComponent.GeneralP2Default;
        }
    }

    public bool IsPickedUp
    {
        get;
        set;
    }

    public CardSpotComponent CardSpot
    {
        get;
        set;
    }
}
