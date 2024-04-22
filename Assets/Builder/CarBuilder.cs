using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBuilder
{
   private string _modelName;
   private float _speed;
   private float _acceleration;

   private GameObject _model;
   private GameObject _wheel;
   private GameObject _glass;

   private readonly Car _car;
   
   public CarBuilder(GameObject selectedModel)
   {
      _car = selectedModel.AddComponent<Car>();
      _car.Model= selectedModel;
   }
   public CarBuilder WithWheel(GameObject wheel)
   {
      _car.Wheel = wheel;
      return this;
   }
   
   public CarBuilder WithGlass(GameObject glass)
   {
      _car.Glasses = glass;
      return this;
   }
   
   public CarBuilder WithTransform(Vector3 position)
   {
      _car.transform.position = position;
      return this;
   }

   public CarBuilder WithRotation(Quaternion rotation)
   {
      _car.transform.rotation = rotation;
      return this;
   }

   public CarBuilder WithName(string name)
   {
      _modelName = name;
      return this;
   }
   
   public CarBuilder WithSpeed(float speed)
   {
      _speed = speed;
      return this;
   }
   
   public CarBuilder WithAcceleration(float acceleration)
   {
      _acceleration = acceleration;
      return this;
   }
   
   public void Build()
   {
      _car.ModelName = _modelName;
      _car.Speed = _speed;
      _car.Model = _model;
      _car.Acceleration = _acceleration;
      _car.Wheel = _wheel;
      _car.Glasses = _glass;
   }
   
}
