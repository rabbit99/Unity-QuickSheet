using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
/// 
[System.Serializable]
public class ExcelExampleData
{
  [SerializeField]
  int iD;
  public int ID { get {return iD; } set { iD = value;} }
  
  [SerializeField]
  string name;
  public string Name { get {return name; } set { name = value;} }
  
  [SerializeField]
  float strength;
  public float Strength { get {return strength; } set { strength = value;} }
  
  [SerializeField]
  Difficulty difficulty;
  public Difficulty DIFFICULTY { get {return difficulty; } set { difficulty = value;} }
  
  [SerializeField]
  float strengthValue;
  public float StrengthValue { get {return strengthValue; } set { strengthValue = value;} }
  
  [SerializeField]
  int[] associatedID = new int[0];
  public int[] AssociatedID { get {return associatedID; } set { associatedID = value;} }
  
}