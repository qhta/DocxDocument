namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the CompoundLineValues enumeration.
/// </summary>
public enum CompoundLine
{
  /// <summary>
  /// sng.
  /// </summary>
  [XmlEnum("sng")]
  Simple,
  
  /// <summary>
  /// dbl.
  /// </summary>
  [XmlEnum("dbl")]
  Double,
  
  /// <summary>
  /// thickThin.
  /// </summary>
  [XmlEnum("thickThin")]
  ThickThin,
  
  /// <summary>
  /// thinThick.
  /// </summary>
  [XmlEnum("thinThick")]
  ThinThick,
  
  /// <summary>
  /// tri.
  /// </summary>
  [XmlEnum("tri")]
  Triple,
  
}
