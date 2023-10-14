namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Horizontal Relative Positioning
/// </summary>
public enum HorizontalRelativePositionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;margin&quot;.
  /// </summary>
  Margin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;page&quot;.
  /// </summary>
  Page,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;column&quot;.
  /// </summary>
  Column,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;character&quot;.
  /// </summary>
  Character,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftMargin&quot;.
  /// </summary>
  LeftMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightMargin&quot;.
  /// </summary>
  RightMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;insideMargin&quot;.
  /// </summary>
  InsideMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;outsideMargin&quot;.
  /// </summary>
  OutsideMargin,
  
}
