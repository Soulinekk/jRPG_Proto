using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JRPG_Game
{
    namespace Map
    {

        public class FieldsInfoContainer : MonoBehaviour
        {

            public List<FieldInfo> fields = new List<FieldInfo>();

        }

        /// <summary>
        /// Info of one field.
        /// </summary>
        public class FieldInfo
        {
            /// <summary>
            /// X, Y position of field.
            /// </summary>
            public Vector2 coordinates;

            /// <summary>
            /// 
            /// </summary>
            public enum Type
            {
                grass,
                pavement,
                forest
            }

            /// <summary>
            /// List of enemies possible to spawn on this field, its spawn chance, and strength multiplier.
            /// </summary>
            public List<Enemy> MobsPossibleToSpawn = new List<Enemy>();
        }

        public class Enemy
        {
            /// <summary>
            /// Id of mob read from serialized object data
            /// </summary>
            public int enemyId;

            /// <summary>
            /// Counted from 0 too 100.
            /// </summary>
            public int spawnChance;

            /// <summary>
            /// Enemy level multiplier, used to strengthen enemies in frields futher, from lower level fields
            /// </summary>
            public float strengthMultiplier;
        }
    }
}
