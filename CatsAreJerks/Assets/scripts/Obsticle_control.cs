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
      
        if (transform.position.y < -10) {
           Destroy(Obsticle);
           Debug.Log("DESTROY!");
        }
    }

   
}

//public class ObjectBehaviour : MonoBehaviour
//{
//    //[SerializeField] GameObject Obsticle;
//    public GameObject Obsticle;

//    public void SpawnObject() 
//    { 
//        Instantiate(Obsticle, new Vector3(Random.Range(-8f,8f),-6f,0f), Quaternion.identity);
//    }
//}