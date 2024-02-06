using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scroll_Speed = 0.1f;
    private MeshRenderer mesh_Renderer;
   
    private void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        Scroll();
    }
    void Scroll()
    {
        mesh_Renderer.material.mainTextureOffset += new Vector2(0, scroll_Speed * Time.deltaTime);
    }
}
