namespace DocumentModel.Drawings;


/// <summary>
///   Text Cap Types
/// </summary>
public enum TextCapsKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;small&quot;.
  /// </summary>
  [EnumString("small")]
  Small,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;all&quot;.
  /// </summary>
  [EnumString("all")]
  All,
  
}
