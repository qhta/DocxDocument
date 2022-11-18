namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Formatting Scope
/// </summary>
public enum Scope
{
  /// <summary>
  /// Selection.
  /// </summary>
  [XmlEnum("selection")]
  Selection,
  
  /// <summary>
  /// Data Fields.
  /// </summary>
  [XmlEnum("data")]
  Data,
  
  /// <summary>
  /// Field Intersections.
  /// </summary>
  [XmlEnum("field")]
  Field,
  
}
