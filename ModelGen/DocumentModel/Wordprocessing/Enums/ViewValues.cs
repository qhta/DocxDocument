namespace DXW;


/// <summary>
///   Defines the ViewValues enumeration.
/// </summary>
public enum ViewValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;print&quot;.
  /// </summary>
  [EnumString("print")]
  Print,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;outline&quot;.
  /// </summary>
  [EnumString("outline")]
  Outline,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;masterPages&quot;.
  /// </summary>
  [EnumString("masterPages")]
  MasterPages,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;normal&quot;.
  /// </summary>
  [EnumString("normal")]
  Normal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;web&quot;.
  /// </summary>
  [EnumString("web")]
  Web,
  
}
