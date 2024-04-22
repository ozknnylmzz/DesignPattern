using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DesignPattern.Buiilder
{
    public class UIManager : MonoBehaviour
    {
       [SerializeField] private List<Button> _model;

       [SerializeField]  private List<Button> _wheel;

       [SerializeField] private List<Button> _glass;

       [SerializeField] private Director _director;

       private int _modelIndex, _wheelIndex, _glassIndex;

       private void OnEnable()
       {
           AddButtonListeners(_glass, _glassIndex, _director.Glasses.Length, _director.SetGlass);
           AddButtonListeners(_wheel, _wheelIndex, _director.Wheels.Length, _director.SetWheel);
           AddButtonListeners(_model, _modelIndex, _director.Models.Length, _director.SetModel);
       }

       private void AddButtonListeners(List<Button> buttonList, int index, int arrayLength, Action<int> setFunction)
       {
           if (buttonList.Count >= 2)
           {
               buttonList[0].onClick.AddListener(() =>
               {
                   ChangeIndex(-1, ref index, arrayLength, setFunction);
                   UpdateButtonColors(buttonList, 0);
               });
               buttonList[1].onClick.AddListener(() =>
               {
                   ChangeIndex(1, ref index, arrayLength, setFunction);
                   UpdateButtonColors(buttonList, 1);
               });
               
           }
       }
       
       private void ChangeIndex(int change, ref int index, int arrayLength, Action<int> setFunction)
       {
           int newIndex = index + change;

           if (newIndex < 0 || newIndex >= arrayLength)
           {
               return; 
           }
    
           index = newIndex;
           setFunction(index); 
       }
       
       private void UpdateButtonColors(List<Button> buttonList, int activeIndex)
       {
           for (int i = 0; i < buttonList.Count; i++)
           {
               buttonList[i].GetComponent<Image>().color = i == activeIndex ? Color.red : Color.green;
           }
       }
    }
}

