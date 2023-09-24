namespace DocumentModel.Drawings;


/// <summary>
///   End Line Cap
/// </summary>
public enum LineCapKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rnd&quot;.
  /// </summary>
  [EnumString("rnd")]
  Round,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sq&quot;.
  /// </summary>
  [EnumString("sq")]
  Square,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flat&quot;.
  /// </summary>
  [EnumString("flat")]
  Flat,
  
}
