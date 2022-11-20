namespace DocumentModel.Spreadsheet;

/// <summary>
/// Underline.
/// </summary>
public interface IUnderline // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Underline Value
  /// </summary>
  public DocumentModel.Spreadsheet.UnderlineValues? Val { get ; set; }
  
}
