namespace DocumentModel.Drawings;

/// <summary>
/// Compound Line Type
/// </summary>
public enum CompoundLineKind
{
  /// <summary>
  /// Single Line.
  /// </summary>
  [XmlEnum("sng")]
  Single,
  
  /// <summary>
  /// Double Lines.
  /// </summary>
  [XmlEnum("dbl")]
  Double,
  
  /// <summary>
  /// Thick Thin Double Lines.
  /// </summary>
  [XmlEnum("thickThin")]
  ThickThin,
  
  /// <summary>
  /// Thin Thick Double Lines.
  /// </summary>
  [XmlEnum("thinThick")]
  ThinThick,
  
  /// <summary>
  /// Thin Thick Thin Triple Lines.
  /// </summary>
  [XmlEnum("tri")]
  Triple,
  
}
