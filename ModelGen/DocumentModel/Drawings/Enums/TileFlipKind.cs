namespace DocumentModel.Drawings;


/// <summary>
///   Tile Flip Mode
/// </summary>
public enum TileFlipKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;x&quot;.
  /// </summary>
  [EnumString("x")]
  Horizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;y&quot;.
  /// </summary>
  [EnumString("y")]
  Vertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;xy&quot;.
  /// </summary>
  [EnumString("xy")]
  HorizontalAndVertical,
  
}
