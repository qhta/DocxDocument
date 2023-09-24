namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageBorderDisplayValues enumeration.
/// </summary>
public enum PageBorderDisplayKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;allPages&quot;.
  /// </summary>
  [EnumString("allPages")]
  AllPages,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;firstPage&quot;.
  /// </summary>
  [EnumString("firstPage")]
  FirstPage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;notFirstPage&quot;.
  /// </summary>
  [EnumString("notFirstPage")]
  NotFirstPage,
  
}
