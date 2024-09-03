using System;
using Unity.VisualScripting;
using UnityEngine;

namespace New_Folder
{
    public class moeda : MonoBehaviour

    {
        public int velocidadeGiro = 5;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Destroy(gameObject);
            }
        }

        void Update()
        {
            transform.Rotate(Vector3.forward * (velocidadeGiro * Time.deltaTime));
            
        }
    }
}
