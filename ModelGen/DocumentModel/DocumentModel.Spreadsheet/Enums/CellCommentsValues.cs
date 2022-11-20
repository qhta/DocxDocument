namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Comments
/// </summary>
public enum CellCommentsValues
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Print Comments As Displayed.
  /// </summary>
  [XmlEnum("asDisplayed")]
  AsDisplayed,
  
  /// <summary>
  /// Print At End.
  /// </summary>
  [XmlEnum("atEnd")]
  AtEnd,
  
}
