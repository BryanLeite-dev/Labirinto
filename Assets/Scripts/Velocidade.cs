using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidade : MonoBehaviour
{
	public float velocidade = 0.1f;
	Vector3 m;
	// Start is called before the first frame update
	void Start()
	{
		m.x = 0.0f;
		m.y = 0.0f;
		m.z = 0.0f;
	}

	// Update is called once per frame
	void Update()

	{

		if (Input.GetKey(KeyCode.Q))
		{
			m.z = velocidade;
			Movimento(m);
			m.y = 0.0f;
			m.x = 0.0f;
		}
		if (Input.GetKey(KeyCode.E))
		{
			m.z = -velocidade;
			Movimento(m);
			m.y = 0.0f;
			m.x = 0.0f;
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

}
