using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace ARFoundationExperiments
{
    [RequiresEntityConversion]
    public class CursorProxy : MonoBehaviour, IConvertGameObjectToEntity
    {
        // Referenced prefabs have to be declared so that the conversion system knows about them ahead of time
        public void DeclareReferencedPrefabs(List<GameObject> gameObjects)
        {
        }

        // Lets you convert the editor data representation to the entity optimal runtime representation
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            var cursorData = new CursorData
            {
            };
            dstManager.AddComponentData(entity, cursorData);
        }
    }
}