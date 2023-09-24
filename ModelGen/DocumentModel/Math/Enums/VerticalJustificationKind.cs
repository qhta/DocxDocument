namespace DocumentModel.Math;


/// <summary>
///   Defines the VerticalJustificationValues enumeration.
/// </summary>
public enum VerticalJustificationKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;top&quot;.
  /// </summary>
  [EnumString("top")]
  Top,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bot&quot;.
  /// </summary>
  [EnumString("bot")]
  Bottom,
  
}
