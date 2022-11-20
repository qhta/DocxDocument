namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the OlapSlicerCacheSelections Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IOlapSlicerCacheSelection))]
public class OlapSlicerCacheSelections: IOlapSlicerCacheSelections
{
  /// <summary>
  /// count, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
