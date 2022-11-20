namespace DocumentModel.Spreadsheet;

/// <summary>
/// HTML Formatting Handling
/// </summary>
public enum HtmlFormattingValues
{
  /// <summary>
  /// No Formatting.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Honor Rich Text.
  /// </summary>
  [XmlEnum("rtf")]
  HonorRichText,
  
  /// <summary>
  /// All.
  /// </summary>
  [XmlEnum("all")]
  All,
  
}
