using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearAfterTouch : MonoBehaviour
{
    public float disapearingTime;
    private bool IsTouch = false;
    IEnumerator OnCollisionExit(Collision coll)
    {
        if (coll.collider.CompareTag("Player") && IsTouch == true)
        {
            yield return new WaitForSeconds(disapearingTime);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            IsTouch = true;
        }
    }
}
