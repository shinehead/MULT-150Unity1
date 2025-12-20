using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = .5f;
    public new Renderer renderer;
    float offset;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        offset += Time.deltaTime * speed;
        if (offset > 1)
            offset -= 1;
        renderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}