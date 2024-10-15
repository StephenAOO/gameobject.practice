using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 300f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(1, 2, 4), speed * Time.deltaTime);
        transform.Rotate(new Vector4(0, 3, 1), speed * Time.deltaTime);
    }
}
