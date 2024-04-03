using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public AnimationCurve ac;
    private Vector3 initialScale;
    private Vector3 finalScale;
    private float graphValue;

    private void Awake()
    {
        initialScale = transform.localScale;
        finalScale = Vector3.one;
        ac.postWrapMode = WrapMode.PingPong;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        graphValue = ac.Evaluate(Time.time * 0.1f);
        transform.localScale = finalScale * graphValue;
    }
}
