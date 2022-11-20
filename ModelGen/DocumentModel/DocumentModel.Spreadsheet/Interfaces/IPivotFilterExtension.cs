namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilterExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IMovingPeriodState))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IPivotFilter))]
public interface IPivotFilterExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
