
using System.Collections.Generic;
using UnityEngine;

public class AutomaticSize : MonoBehaviour
{
    [SerializeField] BoxCollider2D box_2d;
    [SerializeField] RectTransform rectTransform;
    [SerializeField] float distanceToCover;
    [SerializeField] float speed;
    [SerializeField] float wisthsize;
    [SerializeField] float heightsize;
    Vector3 temp;
    void Start()
    {
        box_2d = GetComponent<BoxCollider2D>();
        rectTransform = GetComponent<RectTransform>();
        temp = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = temp;
        v.x += distanceToCover * Mathf.Sin(Time.time * speed);
        v.y += distanceToCover * Mathf.Sin(Time.time * speed);

        var rect = rectTransform.rect;
        box_2d.size = new Vector2(rect.width - wisthsize, rect.height - heightsize);

        transform.localScale = v;
    }
}
