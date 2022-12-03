namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pane State
/// </summary>
public enum PaneStateKind
{
  /// <summary>
  /// Split.
  /// </summary>
  [XmlEnum("split")]
  Split,
  
  /// <summary>
  /// Frozen.
  /// </summary>
  [XmlEnum("frozen")]
  Frozen,
  
  /// <summary>
  /// Frozen Split.
  /// </summary>
  [XmlEnum("frozenSplit")]
  FrozenSplit,
  
}
