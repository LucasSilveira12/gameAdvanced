using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class LapCounter : MonoBehaviour
{
    int nCheckpoint;
    float timeChackpointPassed;
    int nPassedCheckpoints;

    public event Action<LapCounter> OnPassCheckpoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Checkpoint"))
        {
            Checkpoint checkpoint = collision.GetComponent<Checkpoint>();
            if(nCheckpoint + 1 == checkpoint.nCheckpoint)
            {
                nCheckpoint = checkpoint.nCheckpoint;
                nPassedCheckpoints++;
                timeChackpointPassed = Time.time;
                OnPassCheckpoint?.Invoke(this);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
