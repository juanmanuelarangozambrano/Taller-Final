using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    
    private Animator anim;
    public float x, y;
    public float velocidadInicial;
    public float velocidadAgachado;
    public Rigidbody rb;
    public float fuerzaSalto = 10f;
    public bool puedoSaltar;
    
    
    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        anim = GetComponent<Animator>();
        velocidadInicial = velocidadMov;
        velocidadAgachado = velocidadMov * 0.5f;
    }
    void fixedUpdate()
    {
        

    }
    // Update is called once per frame
    void Update() 
    { 


      x=Input.GetAxis("Horizontal");
      y=Input.GetAxis("Vertical");
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
        
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMov / 2);
        transform.Translate(x * Time.deltaTime * velocidadMov / 2, 0, 0);

        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetBool("agacharse", true);
            velocidadMov = velocidadAgachado;
        }
        else
        {
            anim.SetBool("agacharse", false);
            velocidadMov = velocidadInicial;
        }
        if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Saltar", true);
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
            }
            anim.SetBool("tocarsuelo", true);
        }
        else
        {
            EstoyCayendo();
        }

        
    }
    public void EstoyCayendo()
    {
        anim.SetBool("tocarsuelo", false);
        anim.SetBool("Saltar",false);
    }
}
