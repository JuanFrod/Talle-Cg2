using UnityEngine;
using System.Collections;

public class MovJugador : MonoBehaviour
{
    CharacterController jugador;
	private Animator animator;
	private Rigidbody rb;
	private Camera mainCamera;

	[SerializeField]
    public float speed = 6.0f;
	[SerializeField]
    public float alturaSalto = 8.0f;
	[SerializeField]
    public float gravity = 20.0f;
	private Vector3 direccion;


	public int movementType;
	[SerializeField]
	public float sensibilidadCamara = 1.5f;

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
		jugador = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
		mainCamera = Camera.main;
    }

    void Update()
    {
		movimiento();
		movimientoCamara();
		
    }

	void movimiento(){
		
		

		//Movimiento al caminar
		if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
			movementType = 1;
			speed = 3.0f;
		}

		//Movimiento al correr
		if (Input.GetKey(KeyCode.LeftShift)) {
			movementType = 3;
			speed = 5.0f;
		}

		if (jugador.isGrounded)
        {

			float Horizontal = Input.GetAxis("Horizontal");
			float Vertical = Input.GetAxis("Vertical");
            direccion = new Vector3(Horizontal, 0.0f, Vertical);
			
			animator.SetFloat("Speed", direccion.magnitude);
			animator.SetInteger("Type", movementType);
			animator.SetFloat("Horizontal", Horizontal);
			animator.SetFloat("Vertical", Vertical);

			direccion.Normalize();
            direccion *= speed;

			//Posicionar la direcion del movimiento a la del juego
			direccion = transform.TransformDirection(direccion);

        }

        direccion.y -= gravity * Time.deltaTime;
        jugador.Move(direccion * Time.deltaTime);

	}

	void movimientoCamara(){

		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");

		//Mirar a los lados
		Vector3 rotacionY = transform.localEulerAngles;
		rotacionY.y += mouseX * sensibilidadCamara;
		transform.localRotation = Quaternion.AngleAxis(rotacionY.y,Vector3.up);

		//Mirar arriba y abajo
		Vector3 rotacionX = mainCamera.gameObject.transform.localEulerAngles;
		//rotacionX.x = Mathf.Clamp(rotacionX.x,-90f,90f);
		rotacionX.x -= mouseY * sensibilidadCamara;
		mainCamera.gameObject.transform.localRotation = Quaternion.AngleAxis(rotacionX.x,Vector3.right);

	}
}
