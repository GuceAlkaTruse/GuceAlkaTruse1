using System.Collections;
using UnityEngine;

public class Signaling : MonoBehaviour
{
    private AudioSource _source;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _source.Play();
            StartCoroutine(VolumeIncrement());
        }
    }

    private IEnumerator VolumeIncrement()
    {
        for (int i = 0; i < 10; i++)
        {
            _source.volume += 0.1f;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
