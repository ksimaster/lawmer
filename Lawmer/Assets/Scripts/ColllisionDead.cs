using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColllisionDead : MonoBehaviour
{
    public string collisionTag;
    private Animator monsterAnimator;

    private void Start()
    {
        monsterAnimator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision col)
    {
        // Debug.Log(col.gameObject.name);
        if (col.gameObject.CompareTag(collisionTag))
        {
            monsterAnimator.SetBool("Dead", true);
            Invoke("DestroyObject", 1.2f);
   
        }

    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
