using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int width = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        int halfwidth = width / 2;
        int num = 0;
        float y = 0.5f;
        while (num <= 3)
        {
            for (int i = -halfwidth; i < halfwidth; i++)
            {
                Vector3 pos = transform.TransformPoint(new Vector3(i, y, 0));

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = pos;
                cube.transform.rotation = transform.rotation;

                cube.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.value, 1, 1);

                cube.transform.parent = this.transform; //creating cube parenting

                cube.AddComponent<Rigidbody>();
            }
            num ++;
            y++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
