using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralPutDowner : MonoBehaviour
{
    private CardSpotComponent m_cardSpotComponent;
    
    private GeneralComponent m_generalComponentP1;
    private GeneralComponent m_generalComponentP2;
    
    // Start is called before the first frame update
    void Start()
    {
        m_cardSpotComponent = gameObject.GetComponent<CardSpotComponent>();
        
        m_generalComponentP1 = GameObject.FindGameObjectWithTag("GeneralP1").GetComponent<GeneralComponent>();
        m_generalComponentP2 = GameObject.FindGameObjectWithTag("GeneralP2").GetComponent<GeneralComponent>();
    }

    private void OnMouseDown()
    {
        if (TryPutDownGeneral(m_generalComponentP1, m_cardSpotComponent))
        {
            return;
        }

        TryPutDownGeneral(m_generalComponentP2, m_cardSpotComponent);
    }

    private static bool TryPutDownGeneral(GeneralComponent generalComponent, CardSpotComponent cardSpotComponent)
    {
        if (generalComponent.IsPickedUp)
        {
            generalComponent.CardSpot = cardSpotComponent;
            generalComponent.IsPickedUp = false;
            return true;
        }

        return false;
    }
}
