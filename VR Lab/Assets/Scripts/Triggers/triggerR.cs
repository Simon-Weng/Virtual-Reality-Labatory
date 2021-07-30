using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerR : MonoBehaviour
{
    private Color m_oldcolor = Color.white;
    private float triggerNumber;

    public Beam beam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.red;
        triggerNumber = 1f;
        beam.SetTrigger(triggerNumber);
    }

    private void OnTriggerExit(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = m_oldcolor;
        triggerNumber = 1f;
        beam.SetTrigger(triggerNumber);

    }
}
