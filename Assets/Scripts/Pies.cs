using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pies : MonoBehaviour
{
    public Animacion animacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        animacion.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        animacion.puedoSaltar = false;
    }
}
