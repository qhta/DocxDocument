namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the XstringType Class.
/// </summary>
public interface IXstringType // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Content Contains Significant Whitespace
  /// </summary>
  public DocumentModel.SpaceProcessingMode? Space { get ; set; }
  
}
