namespace DocumentModel.Spreadsheet;

/// <summary>
/// Reference Mode
/// </summary>
public enum ReferenceModeValues
{
  /// <summary>
  /// A1 Mode.
  /// </summary>
  [XmlEnum("A1")]
  A1,
  
  /// <summary>
  /// R1C1 Reference Mode.
  /// </summary>
  [XmlEnum("R1C1")]
  R1C1,
  
}
