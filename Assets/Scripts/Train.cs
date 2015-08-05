using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour {
	public float speed = 60F;
	public float timeToMove = 4f;
	public float turnAngle = 45f;
	public float turnSpeed;

	float neededTime;
	Quaternion finalRotation;
	Quaternion currentRotation;

	// Use this for initialization
	void Start () {
		// neededTime = Time.time + timeToMove;
		// finalRotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f,turnAngle, 0f));
		// currentRotation = transform.rotation;
	}


	// Update is called once per frame
	void Update () {	
		
		transform.Translate(Vector3.forward * Time.deltaTime * speed);

		// Проверяем, можно ли уже поворачивать.
	//	if (Time.time >= neededTime)
	//	{
	//		// Находим кватернион нового вращения.
	//		var rotation = Quaternion.RotateTowards(transform.rotation, finalRotation, turnSpeed * Time.deltaTime); 

	//		// Если новое вращение не отличается от текущего, значит вращение завершено
	//		if (transform.rotation == rotation)
	//		{
	//			// Назначаем новое целевое вращение.
	//			finalRotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f,turnAngle, 0f));

	//			// Заводим таймер на новое время.
	//			neededTime = Time.time + timeToMove;
	//		}
			// Если вращение не завершено.
	//		else 
	//		{
				// Применяем вращение.
	//			transform.rotation = rotation;
	//		}
	//	}

//		// Проверяем, можно ли уже поворачивать.
//		if (Time.time >= neededTime)
//		{
//			// Рассчитываем коэффициент времени (от 0 до 1).
//			float t = Mathf.Clamp01((Time.time - neededTime) / turnSpeed);
//
//			// Интерполируем текущее врещение от currrentRotation до finalRotation.
//			transform.rotation = Quaternion.Lerp(currentRotation, finalRotation, t);
//
//			// Если вращение завершено (коэффициент стал == 1)
//			if (t == 1)
//			{
//				// Заводим новый таймер.
//				neededTime = Time.time + timeToMove;
//
//				// Выставляем новое значение начального вращения (текущее).
//				currentRotation = transform.rotation;
//
//				// И финального вращения.
//				finalRotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f,turnAngle, 0f));
//			}
//		}


	
	}
}
