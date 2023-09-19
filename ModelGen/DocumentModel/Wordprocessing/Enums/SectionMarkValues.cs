namespace DXW;


/// <summary>
///   Defines the SectionMarkValues enumeration.
/// </summary>
public enum SectionMarkValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nextPage&quot;.
  /// </summary>
  [EnumString("nextPage")]
  NextPage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nextColumn&quot;.
  /// </summary>
  [EnumString("nextColumn")]
  NextColumn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continuous&quot;.
  /// </summary>
  [EnumString("continuous")]
  Continuous,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;evenPage&quot;.
  /// </summary>
  [EnumString("evenPage")]
  EvenPage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;oddPage&quot;.
  /// </summary>
  [EnumString("oddPage")]
  OddPage,
  
}
