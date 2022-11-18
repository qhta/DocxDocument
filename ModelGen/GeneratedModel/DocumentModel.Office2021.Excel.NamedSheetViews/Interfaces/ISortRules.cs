namespace DocumentModel.Office2021.Excel.NamedSheetViews;

/// <summary>
/// Defines the SortRules Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.NamedSheetViews.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.NamedSheetViews.ISortRule))]
public interface ISortRules // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// sortMethod, this property is only available in Office 2021 and later.
  /// </summary>
  public SortMethod? SortMethod { get ; set; }
  
  /// <summary>
  /// caseSensitive, this property is only available in Office 2021 and later.
  /// </summary>
  public bool? CaseSensitive { get ; set; }
  
}
