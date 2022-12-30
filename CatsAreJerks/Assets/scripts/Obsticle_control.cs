using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleControl : MonoBehaviour
{
    public GameObject Obsticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10) { Destroy(Obsticle); }
    }
}
