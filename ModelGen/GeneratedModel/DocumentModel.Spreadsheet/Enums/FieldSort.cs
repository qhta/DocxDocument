namespace DocumentModel.Spreadsheet;

/// <summary>
/// Field Sort Type
/// </summary>
public enum FieldSort
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
