using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public static Destroyer instance;
    public GameObject sandik;
    // Start is called before the first frame update
public void YokEt()
    {
        Destroy(sandik);

    }
}
