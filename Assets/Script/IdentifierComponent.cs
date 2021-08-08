using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentifierComponent : MonoBehaviour
{
    public IdentifierComponent()
    {
        ID = Guid.NewGuid();
    }

    public Guid ID
    {
        get;
    }
}
