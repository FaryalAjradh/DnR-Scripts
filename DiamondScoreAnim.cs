using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScoreAnim : MonoBehaviour
{
    public Animator anim;
    
    public void CollectAnim()
    {
        anim.SetTrigger("Collect");
    }
}
