using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleClick : MonoBehaviour
{
    Renderer renderer;
    Material material;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        material = renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                material.SetVector("_RippleSource", hit.textureCoord);
            }
        }
    }
}
