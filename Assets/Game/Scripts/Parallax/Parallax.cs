using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float parallaxSpeed;
    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject background;
    private float length, startPos;
    private float bgLength, bgStartPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

        bgStartPos = background.transform.position.x;
        bgLength = background.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dist = (cam.transform.position.x * parallaxSpeed);
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
        background.transform.position = new Vector3(bgStartPos + dist * 0.5f, background.transform.position.y, background.transform.position.z);

        if (dist > startPos + length)
            startPos += length;
        else if (dist < startPos - length)
            startPos -= length;

        if (dist > bgStartPos + bgLength)
            bgStartPos += bgLength;
        else if (dist < bgStartPos - bgLength)
            bgStartPos -= bgLength;
    }

    
}
