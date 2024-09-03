using UnityEngine;
using UnityEngine.SceneManagement;

namespace New_Folder
{
    public class Player : MonoBehaviour
    {
        public int velocidade = 10;
        public Rigidbody  rb;
        public int Pulo = 10;

        public bool noChao = false;
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("hello mundo");
            TryGetComponent(out rb);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "chao")
            {
                noChao = true;
            }
        

        }

        void Update()
        {
            Debug.Log("update");
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            Vector3 direcao = new Vector3(x, 0, y);
            rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
            if ((Input.GetKey(KeyCode.Space)) && noChao)
            {
          
                rb.AddForce(Vector3.up * Pulo, ForceMode.Impulse);
                noChao = false;
            }
            if (transform.position.y < -5)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            }
        }
    }
}