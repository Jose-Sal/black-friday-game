using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    private bool isAttacking = false;
    private bool canattack = true;

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Mouse0) && canattack == true)
        {
            isAttacking = true;
            canattack = false;
            Invoke("CoolDown", .3f);
        }
    }

    public void CoolDown()
    {
        canattack = true;
        isAttacking=false;
    }

}
