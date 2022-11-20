namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the OartAnchorType enumeration.
/// </summary>
public enum OartAnchorType
{
  /// <summary>
  /// twoCell.
  /// </summary>
  [XmlEnum("twoCell")]
  TwoCell,
  
  /// <summary>
  /// oneCell.
  /// </summary>
  [XmlEnum("oneCell")]
  OneCell,
  
  /// <summary>
  /// absolute.
  /// </summary>
  [XmlEnum("absolute")]
  Absolute,
  
}
