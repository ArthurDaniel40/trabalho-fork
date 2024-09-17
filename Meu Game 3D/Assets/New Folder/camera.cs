using UnityEngine;

namespace New_Folder
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform playerTransform; // Referência direta ao objeto "Player"
        [SerializeField] private Vector3 offset;
        public Vector2 mouseInput;
        void Start()
        {
            if (playerTransform == null)
            {
                // Busca o objeto "Player" por tag (opcional)
                playerTransform = GameObject.FindWithTag("Player").transform;
                offset = playerTransform.position - transform.position;
            }
        }

        void Update()
        {
            mouseInput = new Vector2(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y")).normalized;
           // float anguloX = transform.eulerAngles.x;
            float anguloY = transform.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0,anguloY+mouseInput.y,0);
            
            
            
            if (playerTransform != null)
            {
                transform.position = playerTransform.position - offset;
            }
        }
    }
}