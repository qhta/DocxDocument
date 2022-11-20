namespace DocumentModel.Office2021.Excel.NamedSheetViews;

/// <summary>
/// Defines the NamedSheetView Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.NamedSheetViews.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.NamedSheetViews.INsvFilter))]
public interface INamedSheetView // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get ; set; }
  
}
