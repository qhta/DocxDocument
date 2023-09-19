namespace DXW;


/// <summary>
///   Defines the EndnotePositionValues enumeration.
/// </summary>
public enum EndnotePositionValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sectEnd&quot;.
  /// </summary>
  [EnumString("sectEnd")]
  SectionEnd,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;docEnd&quot;.
  /// </summary>
  [EnumString("docEnd")]
  DocumentEnd,
  
}
