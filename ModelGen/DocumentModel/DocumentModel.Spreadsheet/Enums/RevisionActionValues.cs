namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Action Types
/// </summary>
public enum RevisionActionValues
{
  /// <summary>
  /// Add.
  /// </summary>
  [XmlEnum("add")]
  Add,
  
  /// <summary>
  /// Delete.
  /// </summary>
  [XmlEnum("delete")]
  Delete,
  
}
