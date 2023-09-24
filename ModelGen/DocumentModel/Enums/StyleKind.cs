namespace DocumentModel;


/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
public enum StyleKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;normal&quot;.
  /// </summary>
  [EnumString("normal")]
  Normal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;warning&quot;.
  /// </summary>
  [EnumString("warning")]
  Warning,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;error&quot;.
  /// </summary>
  [EnumString("error")]
  Error,
  
}
