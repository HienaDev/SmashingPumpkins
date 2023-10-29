using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
	[SerializeField]
	private Vector3 _pos1 = new Vector3(-4, 0, 0);
	[SerializeField]
	private Vector3 _pos2 = new Vector3(4, 0, 0);
	[SerializeField]
	private float _speed = 1.0f;
	[SerializeField]
	private GameObject _player;
	[SerializeField]
	private GameObject _pumpkin;
	private bool _pumpkinReady = true;

	void Update()
	{
		transform.position = Vector3.Lerp(_pos1, _pos2, (Mathf.Sin(_speed * Time.time) + 1.0f) / 2.0f);

		if (Mathf.Abs(transform.position.x - _player.transform.position.x) < 0.1f && _pumpkinReady)
        {
			Instantiate(_pumpkin, transform.position, Quaternion.identity);
			_pumpkinReady = false;
			Debug.Log(transform.position.x);
			Debug.Log(_player.transform.position.x);
			StartCoroutine(PumpkinCooldownCoroutine());
        }
	}

	IEnumerator PumpkinCooldownCoroutine()
    {
		yield return new WaitForSeconds(1f);
		_pumpkinReady = true;
    }
}
