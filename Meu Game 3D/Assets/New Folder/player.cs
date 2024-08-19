using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Callbacks;
using UnityEngine;

public class player : MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rigido;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("iniciar");
        TryGetComponent(out rigido);
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log("update"); 
       float x = Input.GetAxis("horizontal");
       float y = Input.GetAxis("Vertical");
       UnityEngine.Vector3 Direcao = new UnityEngine.Vector3(x, 0, y);
       rigido.AddForce(Direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
    }
}
