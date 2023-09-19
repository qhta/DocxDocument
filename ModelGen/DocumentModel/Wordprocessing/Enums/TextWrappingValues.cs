namespace DXW;


/// <summary>
///   Defines the TextWrappingValues enumeration.
/// </summary>
public enum TextWrappingValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;auto&quot;.
  /// </summary>
  [EnumString("auto")]
  Auto,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;notBeside&quot;.
  /// </summary>
  [EnumString("notBeside")]
  NotBeside,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;around&quot;.
  /// </summary>
  [EnumString("around")]
  Around,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tight&quot;.
  /// </summary>
  [EnumString("tight")]
  Tight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;through&quot;.
  /// </summary>
  [EnumString("through")]
  Through,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
}
