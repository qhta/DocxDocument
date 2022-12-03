namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataBarDirectionValues enumeration.
/// </summary>
public enum DataBarDirectionKind
{
  /// <summary>
  /// context.
  /// </summary>
  [XmlEnum("context")]
  Context,
  
  /// <summary>
  /// leftToRight.
  /// </summary>
  [XmlEnum("leftToRight")]
  LeftToRight,
  
  /// <summary>
  /// rightToLeft.
  /// </summary>
  [XmlEnum("rightToLeft")]
  RightToLeft,
  
}
