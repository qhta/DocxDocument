namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the JustificationValues enumeration.
/// </summary>
public enum JustificationKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;left&quot;.
  /// </summary>
  [EnumString("left")]
  Left,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;start&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("start")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  Start,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;center&quot;.
  /// </summary>
  [EnumString("center")]
  Center,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;right&quot;.
  /// </summary>
  [EnumString("right")]
  Right,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;end&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("end")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  End,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;both&quot;.
  /// </summary>
  [EnumString("both")]
  Both,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mediumKashida&quot;.
  /// </summary>
  [EnumString("mediumKashida")]
  MediumKashida,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;distribute&quot;.
  /// </summary>
  [EnumString("distribute")]
  Distribute,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;numTab&quot;.
  /// </summary>
  [EnumString("numTab")]
  NumTab,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;highKashida&quot;.
  /// </summary>
  [EnumString("highKashida")]
  HighKashida,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lowKashida&quot;.
  /// </summary>
  [EnumString("lowKashida")]
  LowKashida,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiDistribute&quot;.
  /// </summary>
  [EnumString("thaiDistribute")]
  ThaiDistribute,
  
}
