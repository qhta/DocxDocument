namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataBarDirectionValues enumeration.
/// </summary>
public enum DataBarDirection
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
