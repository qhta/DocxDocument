namespace DocumentModel.Spreadsheet;

/// <summary>
/// Parameter Type
/// </summary>
public enum ParameterValues
{
  /// <summary>
  /// Prompt on Refresh.
  /// </summary>
  [XmlEnum("prompt")]
  Prompt,
  
  /// <summary>
  /// Value.
  /// </summary>
  [XmlEnum("value")]
  Value,
  
  /// <summary>
  /// Parameter From Cell.
  /// </summary>
  [XmlEnum("cell")]
  Cell,
  
}
