using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JRPG_Game
{
    namespace Map
    {

        public class FieldsInfoContainer : MonoBehaviour
        {
            

        }

        /// <summary>
        /// Info of one field.
        /// </summary>
        public class FieldInfo
        {
            /// <summary>
            /// X, Y position of field.
            /// </summary>
            public Vector3 coordinates;

            /// <summary>
            /// 0 - Middle upper field, rest go clockwise.
            /// </summary>
            public int[] neighbors;

            /// <summary>
            /// 
            /// </summary>
            public enum Type
            {
                grass,
                pavement,
                forest
            }
            public Type type;

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
