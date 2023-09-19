namespace DXW;


/// <summary>
///   Defines the FrameLayoutValues enumeration.
/// </summary>
public enum FrameLayoutValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rows&quot;.
  /// </summary>
  [EnumString("rows")]
  Rows,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cols&quot;.
  /// </summary>
  [EnumString("cols")]
  Columns,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
}
