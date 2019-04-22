using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace ARFoundationExperiments
{
    [RequiresEntityConversion]
    public class CursorProxy : MonoBehaviour, IConvertGameObjectToEntity
    {
        // Lets you convert the editor data representation to the entity optimal runtime representation
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            Debug.Log("Convert");
            var cursorData = new CursorData
            {
            };
            dstManager.AddComponentData(entity, cursorData);
        }
    }
}