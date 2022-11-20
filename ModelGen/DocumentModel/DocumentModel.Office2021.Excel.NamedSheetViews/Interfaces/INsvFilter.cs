namespace DocumentModel.Office2021.Excel.NamedSheetViews;

/// <summary>
/// Defines the NsvFilter Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.NamedSheetViews.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.NamedSheetViews.IColumnFilter))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.NamedSheetViews.ISortRules))]
public interface INsvFilter // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// filterId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? FilterId { get ; set; }
  
  /// <summary>
  /// ref, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Ref { get ; set; }
  
  /// <summary>
  /// tableId, this property is only available in Office 2021 and later.
  /// </summary>
  public uint? TableId { get ; set; }
  
}
