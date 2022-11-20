namespace DocumentModel.Drawing;

/// <summary>
/// Font Alignment Types
/// </summary>
public enum TextFontAlignmentValues
{
  /// <summary>
  /// Font Alignment Enum ( Automatic ).
  /// </summary>
  [XmlEnum("auto")]
  Automatic,
  
  /// <summary>
  /// Font Alignment Enum ( Top ).
  /// </summary>
  [XmlEnum("t")]
  Top,
  
  /// <summary>
  /// Font Alignment Enum ( Center ).
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
  /// <summary>
  /// Font Alignment Enum ( Baseline ).
  /// </summary>
  [XmlEnum("base")]
  Baseline,
  
  /// <summary>
  /// Font Alignment Enum ( Bottom ).
  /// </summary>
  [XmlEnum("b")]
  Bottom,
  
}
