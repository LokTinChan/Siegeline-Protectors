using System.Collections;
using System.Collections.Generic;
using ArcticMoose.Input.Debugging;
using UnityEditor;
using UnityEngine;

namespace ArcticMoose
{
    [CustomEditor(typeof(DebugController))]
    public class DebugControllerEditor : UnityEditor.Editor
    {
        private static int goldValue;
        private static int metalValue;
        private static int gunpowderValue;
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            DebugController debugController = (DebugController)target;
            
            GUILayout.Space(40f);

            EditorGUILayout.LabelField("Resources Controller", EditorStyles.boldLabel);

            goldValue = EditorGUILayout.IntField("Gold: ", goldValue,  EditorStyles.numberField);
            if (GUILayout.Button("Add Gold"))
            {
                debugController.DebugAddGold(goldValue);
            }

            GUILayout.Space(10f);
            
            metalValue = EditorGUILayout.IntField("Metal: ", metalValue, EditorStyles.numberField);
            if (GUILayout.Button("Add Metal"))
            {
                debugController.DebugAddMetal(metalValue);
            }

            GUILayout.Space(10f);
            
            gunpowderValue = EditorGUILayout.IntField("Gunpowder: ",gunpowderValue, EditorStyles.numberField);
            if (GUILayout.Button("Add Gudpowder"))
            {
                debugController.DebugAddGunpowder(gunpowderValue);
            }
            
            GUILayout.Space(20f);
            
            EditorGUILayout.LabelField("Raise Event Controller", EditorStyles.boldLabel);
            
            if (GUILayout.Button("Debug Raise Save Event"))
            {
                debugController.DebugRaiseSaveEvent();
            }
            
            GUILayout.Space(10f);
            
            if (GUILayout.Button("Debug Raise Load Event"))
            {
                debugController.DebugRaiseLoadEvent();
            }
            
            GUILayout.Space(10f);
            
            if (GUILayout.Button("Debug Raise Save Game Completed Event"))
            {
                debugController.DebugRaiseSaveGameCompletedEvent();
            }
            
            GUILayout.Space(10f);
            
            if (GUILayout.Button("Debug Raise Load Game Completed Event"))
            {
                debugController.DebugRaiseLoadGameCompletedEvent();
            }
            
            GUILayout.Space(10f);
            
            if (GUILayout.Button("Debug Raise Resource Supply Event"))
            {
                debugController.DebugRaiseResourceSupplyEvent();
            }

            GUILayout.Space(30f);
        }
    }
}
