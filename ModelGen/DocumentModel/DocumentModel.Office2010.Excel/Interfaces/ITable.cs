namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Table Class.
/// </summary>
public interface ITable // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// altText, this property is only available in Office 2010 and later.
  /// </summary>
  public string? AltText { get ; set; }
  
  /// <summary>
  /// altTextSummary, this property is only available in Office 2010 and later.
  /// </summary>
  public string? AltTextSummary { get ; set; }
  
}
