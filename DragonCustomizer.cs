using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragonCustomizer : MonoBehaviour
{

    

   [Header(" Custom Horn ")]
   public GameObject[] hornGameObjects;
   public int activeHorn;
   
   
   
   [Header(" Custom Body ")]

   public GameObject bodyGameObject;



   [Header(" Custom Spine ")]

   public GameObject[] spineGameObjects;
    public int activeSpine;
   
   
   [Header(" Custom Wing ")]

   public GameObject wingGameObject;




   [Header("Face Selector")]
   public Material[] faceMaterials;
   public GameObject faceGameObject;
   public int faceMaterialIndex;
   
   
   
   [Header("Base prefab Materials")]
   public Material[] baseMaterials;
   public int bodyMaterialIndex;
   public int wingMaterialIndex;
   public int hornMaterialIndex;
   public int spineMaterialIndex;


   public void switchBodyMaterial()
   {
        bodyGameObject.GetComponent<Renderer>().material = baseMaterials[bodyMaterialIndex]; 
   }

    public void switchHornMaterial()
   {
        foreach (GameObject go in hornGameObjects)
            go.GetComponent<Renderer>().material = baseMaterials[hornMaterialIndex];   
   }

    public void switchHornGameObject()
   {
        foreach (GameObject go in hornGameObjects)
            go.SetActive(false);
        hornGameObjects[activeHorn].SetActive(true);
   }
   
   public void switchWingMaterial()
   {
        wingGameObject.GetComponent<Renderer>().material = baseMaterials[wingMaterialIndex];
   }

   public void switchFaceMaterial()
   {
        faceGameObject.GetComponent<Renderer>().material = faceMaterials[faceMaterialIndex];
   }

   public void switchSpineMaterial()
   {
        foreach (GameObject go in spineGameObjects)
            go.GetComponent<Renderer>().material = baseMaterials[spineMaterialIndex];       
   }
   
   public void switchSpineGameObject()
   {
        foreach (GameObject go in spineGameObjects)
            go.SetActive(false);
        spineGameObjects[activeSpine].SetActive(true);
   }


   public void nextBodyMaterial()
   {
        bodyMaterialIndex++;
        if (bodyMaterialIndex >= baseMaterials.Length)
            bodyMaterialIndex =0;
        switchBodyMaterial();

   }

    public void lastBodyMaterial()
    {
        bodyMaterialIndex--;
        if (bodyMaterialIndex < 0)
            bodyMaterialIndex =baseMaterials.Length-1;
        switchBodyMaterial();

   }

     public void nextWingMaterial()
   {
        wingMaterialIndex++;
        if (wingMaterialIndex >= baseMaterials.Length)
            wingMaterialIndex =0;
        switchWingMaterial();

   }

    public void lastWingMaterial()
    {
        wingMaterialIndex--;
        if (wingMaterialIndex < 0)
            wingMaterialIndex =baseMaterials.Length-1;
        switchWingMaterial();

   }



     public void nextHornMaterial()
   {
        hornMaterialIndex++;
        if (hornMaterialIndex >= baseMaterials.Length)
            hornMaterialIndex =0;
        switchHornMaterial();

   }

    public void lastHornMaterial()
    {
        hornMaterialIndex--;
        if (hornMaterialIndex < 0)
            hornMaterialIndex =baseMaterials.Length-1;
        switchHornMaterial();

   }

        public void nextSpineMaterial()
   {
        spineMaterialIndex++;
        if (spineMaterialIndex >= baseMaterials.Length)
            spineMaterialIndex =0;
        switchSpineMaterial();

   }

    public void lastSpineMaterial()
    {
        spineMaterialIndex--;
        if (spineMaterialIndex < 0)
            spineMaterialIndex =baseMaterials.Length-1;
        switchSpineMaterial();

   }
    public void nextfaceMaterial()
   {
        faceMaterialIndex++;
        if (faceMaterialIndex >= faceMaterials.Length)
            faceMaterialIndex =0;
        switchFaceMaterial();

   }

    public void lastFaceMaterial()
    {
        faceMaterialIndex--;
        if (faceMaterialIndex < 0)
            faceMaterialIndex =faceMaterials.Length-1;
        switchFaceMaterial();

   }



     public void nextHornGameObject()
   {
        activeHorn++;
        if (activeHorn >= hornGameObjects.Length)
            activeHorn =0;
        switchHornGameObject();

   }

    public void lastHornGameObject()
    {
        activeHorn--;
        if (activeHorn < 0)
            activeHorn =hornGameObjects.Length-1;
        switchHornGameObject();

   }

    public void nextSpineGameObject()
   {
        activeSpine++;
        if (activeSpine >= spineGameObjects.Length)
            activeSpine =0;
        switchSpineGameObject();

   }

    public void lastSpineGameObject()
    {
        activeSpine--;
        if (activeSpine < 0)
            activeSpine =spineGameObjects.Length-1;
        switchSpineGameObject();

   }


}
