using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JRPG_Game
{
    namespace Map
    {
        public class MapContainer : MonoBehaviour {

            public static MapContainer instance = null;

            
            public Dictionary<int[], FieldInfo> mapChunks = new Dictionary<int[], FieldInfo>();

    private void Awake()
            {
                if (instance == null)
                    instance = this;
                else if (instance != null)
                    Destroy(gameObject);

                DontDestroyOnLoad(gameObject);
            }
        }
    }
}
