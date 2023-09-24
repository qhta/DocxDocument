namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Horizontal Relative Positioning
/// </summary>
public enum HorizontalRelativePositionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;margin&quot;.
  /// </summary>
  [EnumString("margin")]
  Margin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;page&quot;.
  /// </summary>
  [EnumString("page")]
  Page,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;column&quot;.
  /// </summary>
  [EnumString("column")]
  Column,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;character&quot;.
  /// </summary>
  [EnumString("character")]
  Character,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftMargin&quot;.
  /// </summary>
  [EnumString("leftMargin")]
  LeftMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightMargin&quot;.
  /// </summary>
  [EnumString("rightMargin")]
  RightMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;insideMargin&quot;.
  /// </summary>
  [EnumString("insideMargin")]
  InsideMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;outsideMargin&quot;.
  /// </summary>
  [EnumString("outsideMargin")]
  OutsideMargin,
  
}
