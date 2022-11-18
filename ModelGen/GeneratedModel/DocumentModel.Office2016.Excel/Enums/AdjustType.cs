namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the AdjustType enumeration.
/// </summary>
public enum AdjustType
{
  /// <summary>
  /// fmla.
  /// </summary>
  [XmlEnum("fmla")]
  Fmla,
  
  /// <summary>
  /// format.
  /// </summary>
  [XmlEnum("format")]
  Format,
  
  /// <summary>
  /// condFmt.
  /// </summary>
  [XmlEnum("condFmt")]
  CondFmt,
  
  /// <summary>
  /// sparkline.
  /// </summary>
  [XmlEnum("sparkline")]
  Sparkline,
  
  /// <summary>
  /// anchor.
  /// </summary>
  [XmlEnum("anchor")]
  Anchor,
  
  /// <summary>
  /// fmlaNoSticky.
  /// </summary>
  [XmlEnum("fmlaNoSticky")]
  FmlaNoSticky,
  
  /// <summary>
  /// noAdj.
  /// </summary>
  [XmlEnum("noAdj")]
  NoAdj,
  
  /// <summary>
  /// fragile.
  /// </summary>
  [XmlEnum("fragile")]
  Fragile,
  
  /// <summary>
  /// future.
  /// </summary>
  [XmlEnum("future")]
  Future,
  
}
