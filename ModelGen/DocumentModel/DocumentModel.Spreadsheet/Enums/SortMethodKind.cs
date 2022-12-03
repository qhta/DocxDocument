namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sort Method
/// </summary>
public enum SortMethodKind
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
