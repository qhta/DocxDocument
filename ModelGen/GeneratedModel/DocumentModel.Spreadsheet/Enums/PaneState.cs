namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pane State
/// </summary>
public enum PaneState
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
