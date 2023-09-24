namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageBorderZOrderValues enumeration.
/// </summary>
public enum PageBorderZOrderKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;front&quot;.
  /// </summary>
  [EnumString("front")]
  Front,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;back&quot;.
  /// </summary>
  [EnumString("back")]
  Back,
  
}
