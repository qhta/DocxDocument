namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the OlapSlicerCacheLevelData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IOlapSlicerCacheRanges))]
public interface IOlapSlicerCacheLevelData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// uniqueName, this property is only available in Office 2010 and later.
  /// </summary>
  public string? UniqueName { get ; set; }
  
  /// <summary>
  /// sourceCaption, this property is only available in Office 2010 and later.
  /// </summary>
  public string? SourceCaption { get ; set; }
  
  /// <summary>
  /// count, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Count { get ; set; }
  
  /// <summary>
  /// sortOrder, this property is only available in Office 2010 and later.
  /// </summary>
  public OlapSlicerCacheSortOrder? SortOrder { get ; set; }
  
  /// <summary>
  /// crossFilter, this property is only available in Office 2010 and later.
  /// </summary>
  public SlicerCacheCrossFilter? CrossFilter { get ; set; }
  
  /// <summary>
  /// OlapSlicerCacheRanges.
  /// </summary>
  public IOlapSlicerCacheRanges? OlapSlicerCacheRanges { get ; set; }
  
}
