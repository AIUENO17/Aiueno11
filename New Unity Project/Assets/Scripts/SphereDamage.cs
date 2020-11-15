using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDamage : MonoBehaviour
{

    private SphereStates m_sphereStates = null;

    // Start is called before the first frame update
    private void Awake()
    { 
        m_sphereStates = GetComponent<SphereStates>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {

            m_sphereStates.SphereHp--;
       
        AddSphereDamage(1);
    }
}

public void AddSphereDamage(int damage)
{
    m_sphereStates.SphereHp -= damage;
}
}