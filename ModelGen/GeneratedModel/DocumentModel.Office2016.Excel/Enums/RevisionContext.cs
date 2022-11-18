namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevisionContext enumeration.
/// </summary>
public enum RevisionContext
{
  /// <summary>
  /// normal.
  /// </summary>
  [XmlEnum("normal")]
  Normal,
  
  /// <summary>
  /// undo.
  /// </summary>
  [XmlEnum("undo")]
  Undo,
  
  /// <summary>
  /// redo.
  /// </summary>
  [XmlEnum("redo")]
  Redo,
  
  /// <summary>
  /// copy.
  /// </summary>
  [XmlEnum("copy")]
  Copy,
  
}
