using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace JRPG_Game
{
    namespace Map
    {
        public class MapFieldsIDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
        {
            MapFieldsIDragStateMachine stateMachine = new MapFieldsIDragStateMachine();

            public void OnBeginDrag(PointerEventData eventData)
            {

            }

            public void OnDrag(PointerEventData eventData)
            {

            }

            public void OnEndDrag(PointerEventData eventData)
            {

            }
        }
    }
}


