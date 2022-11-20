namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CustomFilters Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ICustomFilter))]
public interface ICustomFilters // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// and, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? And { get ; set; }
  
}
