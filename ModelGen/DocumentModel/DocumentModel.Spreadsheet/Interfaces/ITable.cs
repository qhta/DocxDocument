namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Table Class.
/// </summary>
public interface ITable // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// altText, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? AltText { get ; set; }
  
  /// <summary>
  /// altTextSummary, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? AltTextSummary { get ; set; }
  
}
