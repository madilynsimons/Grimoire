using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextMesh = gameObject.GetComponent<TextMesh>();
    }

    public TextMesh TextMesh
    {
        get;
        private set;
    }
}
