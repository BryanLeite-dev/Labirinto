using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	public float velocidade = 0.1f;
	bool isLeftButtonDown ;
	bool isRightButtonDown ;
	bool isMiddleButtonDown ;
	Vector3 m;
    // Start is called before the first frame update
    void Start()
    {
        isLeftButtonDown = false;
		isRightButtonDown = false;
		isMiddleButtonDown  = false;
		m.x = 0.0f;
		m.y = 0.0f;
		m.z = 0.0f;
    }

    // Update is called once per frame
    void Update()

    {
		
		if (Input.GetKey (KeyCode.W)) {
			m.y = velocidade;
			Movimento(m);
			m.x = 0.0f;
			m.z = 0.0f;
   }  
        if (Input.GetKey (KeyCode.S)) {

			m.y = -velocidade;
			Movimento(m);
			m.x = 0.0f;
			m.z = 0.0f;

		}  
        if (Input.GetKey (KeyCode.D)) {
			m.x = -velocidade;
			Movimento(m);
			m.y = 0.0f;
			m.z = 0.0f;
			
		}  
        if (Input.GetKey (KeyCode.A)) {
			m.x = velocidade;
			Movimento(m);
			m.y = 0.0f;
			m.z = 0.0f;
		}
		if (Input.GetKey (KeyCode.Space)) {
			m.z = 0.05f;
			Movimento(m);
			m.y = 0.0f;
			m.x = 0.0f;
		}
		if (Input.GetKey(KeyCode.LeftShift))
		{
			m.z = -0.05f;
			Movimento(m);
			m.y = 0.0f;
			m.x = 0.0f;
		}
		isLeftButtonDown = Input.GetMouseButtonDown (0);
    isRightButtonDown = Input.GetMouseButtonDown (1);    
    isMiddleButtonDown = Input.GetMouseButtonDown (2);  
       /*print (isLeftButtonDown);  
		print (isMiddleButtonDown );
		print(isRightButtonDown);*/
	   if (isLeftButtonDown)
        {
			//m.x = 0.5f;
			Rotacao(m);
			LogMessage("Botão esquerdo");
			isLeftButtonDown = false;
		}

	   if (isRightButtonDown )
        {
			LogMessage("Botão Direito");
			isRightButtonDown = false;
		}

        if (isMiddleButtonDown)
        {
			LogMessage("Botão do meio");
			isMiddleButtonDown = false;
		}

		
		
		
	}

	void Rotacao(Vector3 x)
    {
		transform.Rotate(x);
    }

	void Movimento(Vector3 m)
    {
		transform.Translate(m);

	}
	
	void LogMessage( string msg)
	{

		Debug.Log("A opção selecionada foi " + msg.ToUpper());
	}


}
