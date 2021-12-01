using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private bool collected = false;

    public bool Pickup()
    {
        if (collected)
            return false;

        collected = true;
        Destroy(gameObject);

        return true;

    }

}
