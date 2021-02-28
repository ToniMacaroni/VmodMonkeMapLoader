﻿using BepInEx;
using Bepinject;
using System.Collections;
using UnityEngine;
using Utilla;
using VmodMonkeMapLoader.Behaviours;
using VmodMonkeMapLoader.Helpers;
using VmodMonkeMapLoader.Models;
using VmodMonkeMapLoader.Patches;

namespace VmodMonkeMapLoader
{
    [BepInPlugin("org.vadix.gorillatag.maploader", "Vmod Monke Map Loader", "1.0.0")]
    [BepInDependency("tonimacaroni.computerinterface")]
    [BepInDependency("org.legoandmars.gorillatag.utilla")]
    public class MonkeMapLoaderPlugin : BaseUnityPlugin
    {
        void Awake()
        {
            Debug.Log("Vmod Monke Map Loader started");
            
            Zenjector.Install<MainInstaller>().OnProject();

            //StartCoroutine(Test());
        }

        IEnumerator Test()
        {
            yield return new WaitForSeconds(5f);
            

            //var mapLoaderObject = new GameObject("MapLoader");
            //var mapLoader = mapLoaderObject.AddComponent<MapLoader>();
            ////var mapLoaderGameObject = new MapLoaderObject
            ////{
            ////    MapLoaderGameObject = mapLoaderObject
            ////};
            //mapLoader.InitializeMapObjects();
            //GlobalData.GetMapFileNames();
            //mapLoader.LoadMap();

            //PlayerTeleportPatch.TeleportPlayer(MapHelper.TeleportTargetToBigTree);
        }
    }
}