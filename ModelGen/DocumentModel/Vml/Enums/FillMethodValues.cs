namespace DXV;


/// <summary>
///   Gradient Fill Computation Type
/// </summary>
public enum FillMethodValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;linear&quot;.
  /// </summary>
  [EnumString("linear")]
  Linear,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sigma&quot;.
  /// </summary>
  [EnumString("sigma")]
  Sigma,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;any&quot;.
  /// </summary>
  [EnumString("any")]
  Any,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;linear sigma&quot;.
  /// </summary>
  [EnumString("linear sigma")]
  Linearsigma,
  
}
