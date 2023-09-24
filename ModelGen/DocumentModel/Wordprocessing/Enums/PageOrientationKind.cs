namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageOrientationValues enumeration.
/// </summary>
public enum PageOrientationKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;portrait&quot;.
  /// </summary>
  [EnumString("portrait")]
  Portrait,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;landscape&quot;.
  /// </summary>
  [EnumString("landscape")]
  Landscape,
  
}
