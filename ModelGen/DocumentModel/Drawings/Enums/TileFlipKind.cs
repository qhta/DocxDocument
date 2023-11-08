namespace DocumentModel.Drawings;


/// <summary>
///   Tile Flip Mode
/// </summary>
public enum TileFlipKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;x&quot;.
  /// </summary>
  Horizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;y&quot;.
  /// </summary>
  Vertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;xy&quot;.
  /// </summary>
  HorizontalAndVertical,
  
}
