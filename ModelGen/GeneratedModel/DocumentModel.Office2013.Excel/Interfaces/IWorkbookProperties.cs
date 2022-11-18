namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the WorkbookProperties Class.
/// </summary>
public interface IWorkbookProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// chartTrackingRefBase, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? ChartTrackingReferenceBase { get ; set; }
  
}
