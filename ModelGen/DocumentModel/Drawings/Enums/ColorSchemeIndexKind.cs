namespace DocumentModel.Drawings;


/// <summary>
///   Theme Color Reference
/// </summary>
public enum ColorSchemeIndexKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dk1&quot;.
  /// </summary>
  [EnumString("dk1")]
  Dark1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lt1&quot;.
  /// </summary>
  [EnumString("lt1")]
  Light1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dk2&quot;.
  /// </summary>
  [EnumString("dk2")]
  Dark2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lt2&quot;.
  /// </summary>
  [EnumString("lt2")]
  Light2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accent1&quot;.
  /// </summary>
  [EnumString("accent1")]
  Accent1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accent2&quot;.
  /// </summary>
  [EnumString("accent2")]
  Accent2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accent3&quot;.
  /// </summary>
  [EnumString("accent3")]
  Accent3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accent4&quot;.
  /// </summary>
  [EnumString("accent4")]
  Accent4,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accent5&quot;.
  /// </summary>
  [EnumString("accent5")]
  Accent5,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accent6&quot;.
  /// </summary>
  [EnumString("accent6")]
  Accent6,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hlink&quot;.
  /// </summary>
  [EnumString("hlink")]
  Hyperlink,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;folHlink&quot;.
  /// </summary>
  [EnumString("folHlink")]
  FollowedHyperlink,
  
}
