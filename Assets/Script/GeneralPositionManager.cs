using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralPositionManager : MonoBehaviour
{
    private GeneralComponent m_generalComponent;

    private const float m_pickUpHeight = 0f;
    private const float m_putDownHeight = -1f;

    // Start is called before the first frame update
    void Start()
    {
        m_generalComponent = gameObject.GetComponent<GeneralComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        CardSpotComponent cardSpot = m_generalComponent.CardSpot;
        if (cardSpot == null)
        {
            return;
        }
        
        Vector3 currentPosition = transform.position;
        Vector3 cardSpotPosition = cardSpot.Position;
        transform.position = m_generalComponent.IsPickedUp 
            ? new Vector3(currentPosition.x, m_pickUpHeight, currentPosition.z) 
            : new Vector3(cardSpotPosition.x, m_putDownHeight, cardSpotPosition.z);
        
        
    }
}
