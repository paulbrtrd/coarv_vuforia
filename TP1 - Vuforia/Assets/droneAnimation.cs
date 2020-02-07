using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneAnimation : MonoBehaviour
{
    private Animator m_Animator;
    private bool scanning = false;
    private bool facing = false;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Scanning Toogle: " + scanning);
            scanning = !scanning;
            m_Animator.SetBool("IsScanning", scanning);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Facing Objet Toogle: " + facing);
            facing = !facing;
            m_Animator.SetBool("IsFacingObject", facing);
        }

    }
}
