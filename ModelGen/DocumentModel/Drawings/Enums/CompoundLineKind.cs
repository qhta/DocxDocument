namespace DocumentModel.Drawings;


/// <summary>
///   Compound Line Type
/// </summary>
public enum CompoundLineKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sng&quot;.
  /// </summary>
  Single,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dbl&quot;.
  /// </summary>
  Double,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thickThin&quot;.
  /// </summary>
  ThickThin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thinThick&quot;.
  /// </summary>
  ThinThick,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tri&quot;.
  /// </summary>
  Triple,
  
}
