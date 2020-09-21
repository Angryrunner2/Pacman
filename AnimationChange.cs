using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChange : MonoBehaviour
{
    public Animator animatorController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
                animatorController.SetTrigger("goDown");
        }
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                animatorController.SetTrigger("goLeft");
        }
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
                animatorController.SetTrigger("goRight");
        }
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
                animatorController.SetTrigger("goUp");
        }
    }
}
