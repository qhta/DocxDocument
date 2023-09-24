namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableLayoutValues enumeration.
/// </summary>
public enum TableLayoutKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fixed&quot;.
  /// </summary>
  [EnumString("fixed")]
  Fixed,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;autofit&quot;.
  /// </summary>
  [EnumString("autofit")]
  Autofit,
  
}
