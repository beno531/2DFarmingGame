using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetectOrder : MonoBehaviour
{
    [SerializeField]
    private int sortingOrderBase = 5000;

    [SerializeField]
    private float offset = -1.5f;

    private void Start()
    {
        var rd = gameObject.GetComponent<Renderer>();

        rd.sortingOrder = (int)(sortingOrderBase - transform.position.y - offset);
    }

}

