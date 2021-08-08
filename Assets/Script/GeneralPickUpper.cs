using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralPickUpper : MonoBehaviour
{
    // Component dependencies
    private GeneralComponent m_generalComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        m_generalComponent = gameObject.GetComponent<GeneralComponent>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseUp()
    {
        TryPickUp();
    }

    private bool TryPickUp()
    {
        if (m_generalComponent.IsPickedUp)
        {
            return false;
        }

        m_generalComponent.IsPickedUp = true;
        return true;
    }
}
