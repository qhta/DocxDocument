namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TextDirectionValues enumeration.
/// </summary>
public enum TextDirectionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lrTb&quot;.
  /// </summary>
  [EnumString("lrTb")]
  LefToRightTopToBottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tb&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("tb")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  LeftToRightTopToBottom2010,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tbRl&quot;.
  /// </summary>
  [EnumString("tbRl")]
  TopToBottomRightToLeft,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rl&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("rl")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  TopToBottomRightToLeft2010,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;btLr&quot;.
  /// </summary>
  [EnumString("btLr")]
  BottomToTopLeftToRight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lr&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("lr")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  BottomToTopLeftToRight2010,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lrTbV&quot;.
  /// </summary>
  [EnumString("lrTbV")]
  LefttoRightTopToBottomRotated,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tbV&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("tbV")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  LeftToRightTopToBottomRotated2010,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tbRlV&quot;.
  /// </summary>
  [EnumString("tbRlV")]
  TopToBottomRightToLeftRotated,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rlV&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("rlV")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  TopToBottomRightToLeftRotated2010,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tbLrV&quot;.
  /// </summary>
  [EnumString("tbLrV")]
  TopToBottomLeftToRightRotated,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lrV&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("lrV")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  TopToBottomLeftToRightRotated2010,
  
}
