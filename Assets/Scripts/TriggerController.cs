using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerController : MonoBehaviour
{
    [SerializeField] PlayableDirector timeln;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timeln.Play();
            Destroy(timeln, 35);
        }
    }
}
