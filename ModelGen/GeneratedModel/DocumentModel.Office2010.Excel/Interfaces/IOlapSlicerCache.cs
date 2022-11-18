namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the OlapSlicerCache Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IOlapSlicerCacheLevelsData))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IOlapSlicerCacheSelections))]
public interface IOlapSlicerCache // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// pivotCacheId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? PivotCacheId { get ; set; }
  
  /// <summary>
  /// OlapSlicerCacheLevelsData.
  /// </summary>
  public IOlapSlicerCacheLevelsData? OlapSlicerCacheLevelsData { get ; set; }
  
  /// <summary>
  /// OlapSlicerCacheSelections.
  /// </summary>
  public IOlapSlicerCacheSelections? OlapSlicerCacheSelections { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
