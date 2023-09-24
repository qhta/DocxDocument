namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FontPitchValues enumeration.
/// </summary>
public enum FontPitchKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fixed&quot;.
  /// </summary>
  [EnumString("fixed")]
  Fixed,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;variable&quot;.
  /// </summary>
  [EnumString("variable")]
  Variable,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;default&quot;.
  /// </summary>
  [EnumString("default")]
  Default,
  
}
