namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the Outlines Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IOutline))]
public interface IOutlines // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// isRow, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? IsRow { get ; set; }
  
}
