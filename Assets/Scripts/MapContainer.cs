using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapContainer : MonoBehaviour {

    public static MapContainer instance = null;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
