namespace DXW;


/// <summary>
///   Defines the PresetZoomValues enumeration.
/// </summary>
public enum PresetZoomValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fullPage&quot;.
  /// </summary>
  [EnumString("fullPage")]
  FullPage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bestFit&quot;.
  /// </summary>
  [EnumString("bestFit")]
  BestFit,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textFit&quot;.
  /// </summary>
  [EnumString("textFit")]
  TextFit,
  
}
