 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JRPG_Game
{
    namespace Map
    {
        namespace MapGenerating
        {

            public class _TestMapGenerator : MonoBehaviour
            {
                FieldsInfoContainer fieldinfoContainer;
                public int chunkSize = 100;

                public GameObject textPrefab;
                public Transform textParentTransform;

                public void GenerateGrid()
                {
                    List<FieldInfo> chunk = new List<FieldInfo>();
                    Vector3 currentField = new Vector3(0, 0, 0);
                    int index = 0;

                    for (int j = 0; j < 5; j++)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            FieldInfo field = new FieldInfo();

                            FillFieldWithData(index, currentField, ref field);
                            chunk.Add(field);

                            SpawnText(currentField, j * i);

                            currentField = new Vector3(currentField.x, currentField.y - 1, currentField.z);
                        }

                        currentField = new Vector3(currentField.x + 1, currentField.y, currentField.z);

                        for (int i = 0; i < 9; i++)
                        {
                            FieldInfo field = new FieldInfo();

                            FillFieldWithData(index, currentField, ref field);
                            chunk.Add(field);

                            currentField = new Vector3(currentField.x, currentField.y + 1, currentField.z);
                        }
                    }

                }

                int[] GetNeighbor(int currentIndexInChunk)
                {
                    int[] ttt = { 0 };

                    return ttt;
                }

                public virtual void FillFieldWithData(int id, Vector3 coords, ref FieldInfo field)
                {


                }

                void SpawnText(Vector3 position, int id)
                {
                    GameObject textPref = Instantiate(textPrefab, position, Quaternion.identity, textParentTransform);
                    textPref.GetComponent<TextMesh>().text = "Field_" + id.ToString();
                }
            }
        }
    }
}
