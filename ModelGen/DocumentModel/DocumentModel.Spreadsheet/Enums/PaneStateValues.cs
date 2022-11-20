namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pane State
/// </summary>
public enum PaneStateValues
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
