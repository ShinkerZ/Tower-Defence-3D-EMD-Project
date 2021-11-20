using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blueprint : MonoBehaviour
{
    RaycastHit rch;
    Vector3 mouseMovement;
    public GameObject preFab;

    void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out rch, 50000f, (1 << 8)))
        {
            transform.position = rch.point;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(preFab.transform, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
