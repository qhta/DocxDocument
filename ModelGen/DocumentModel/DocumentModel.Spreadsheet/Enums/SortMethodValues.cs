namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sort Method
/// </summary>
public enum SortMethodValues
{
  /// <summary>
  /// Sort by Stroke.
  /// </summary>
  [XmlEnum("stroke")]
  Stroke,
  
  /// <summary>
  /// PinYin Sort.
  /// </summary>
  [XmlEnum("pinYin")]
  PinYin,
  
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
