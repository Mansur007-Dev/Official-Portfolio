using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public float DestroyTime = 0.2f;
    public Vector3 offset = new Vector3(0, -2, 0);
    void Start()
    {
        Destroy(gameObject, DestroyTime);
        transform.localPosition += offset;

        // Update is called once per frame
        void Update()
        {

        }
    }
}
