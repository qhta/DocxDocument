namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the SizeRelativeVerticallyValues enumeration.
/// </summary>
public enum SizeRelativeVerticallyKind
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
  ///   When the item is serialized out as xml, its value is &quot;topMargin&quot;.
  /// </summary>
  [EnumString("topMargin")]
  TopMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bottomMargin&quot;.
  /// </summary>
  [EnumString("bottomMargin")]
  BottomMargin,
  
  
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
