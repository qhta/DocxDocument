namespace DocumentModel.Spreadsheet;

/// <summary>
/// Field Sort Type
/// </summary>
public enum FieldSortValues
{
  /// <summary>
  /// Manual Sort.
  /// </summary>
  [XmlEnum("manual")]
  Manual,
  
  /// <summary>
  /// Ascending.
  /// </summary>
  [XmlEnum("ascending")]
  Ascending,
  
  /// <summary>
  /// Descending.
  /// </summary>
  [XmlEnum("descending")]
  Descending,
  
}
