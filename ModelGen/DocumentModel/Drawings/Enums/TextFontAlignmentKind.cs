namespace DocumentModel.Drawings;


/// <summary>
///   Font Alignment Types
/// </summary>
public enum TextFontAlignmentKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;auto&quot;.
  /// </summary>
  [EnumString("auto")]
  Automatic,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;t&quot;.
  /// </summary>
  [EnumString("t")]
  Top,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ctr&quot;.
  /// </summary>
  [EnumString("ctr")]
  Center,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;base&quot;.
  /// </summary>
  [EnumString("base")]
  Baseline,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;b&quot;.
  /// </summary>
  [EnumString("b")]
  Bottom,
  
}
