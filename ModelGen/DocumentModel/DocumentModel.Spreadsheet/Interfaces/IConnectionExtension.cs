namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConnectionExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IConnection))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IConnection))]
public interface IConnectionExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
