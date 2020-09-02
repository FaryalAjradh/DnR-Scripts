using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPlayerAnimation : MonoBehaviour
{
    //Put your animation clip here, from within the inspector
    public Animator myAnimator;
    float waitTime;
    
    void Start () {
        StartCoroutine(LoopFunction(6f));
    }
    
    private IEnumerator LoopFunction(float waitTime)
    {
        while (true)
        {
            var wave = true;
            myAnimator.SetBool("Wave", wave);
            yield return new WaitForSeconds(waitTime);
            wave = false;
            myAnimator.SetBool("Wave", wave);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
