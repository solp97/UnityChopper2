using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Die();
        }
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
