using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PositionHandler : MonoBehaviour
{
    public List<LapCounter> lapCounters = new List<LapCounter>();
    // Start is called before the first frame update
    void Start()
    {
        //LapCounter[] lapCountersArray = FindObjectOfType<LapCounter>();
        //lapCounters = lapCountersArray.ToList<LapCounter>();
        foreach (LapCounter lapCounter in lapCounters)
            lapCounter.OnPassCheckpoint += OnPassCheckpoint;
    }

    void OnPassCheckpoint(LapCounter lapCounter)
    {
        Debug.Log($"Evento: Carro {lapCounter.gameObject.name} passou p checkpoint");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
