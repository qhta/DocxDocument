namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFieldExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotField))]
public interface IPivotFieldExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
