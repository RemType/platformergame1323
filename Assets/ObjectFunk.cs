using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFunk : MonoBehaviour
{
    [SerializeField] private AnimationCurve _movingCurve;
    private float currentTime;
    private float totalTime;
    
    void Start()
    {
        totalTime = _movingCurve.keys[_movingCurve.keys.Length - 1].time;
    }
    private void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(transform.position.x, _movingCurve.Evaluate(currentTime), transform.position.z); currentTime += Time.fixedDeltaTime; 

        if (currentTime > totalTime)
        {
            currentTime = 0;
        }
    }

    void Update()
    {
        
    }
}
