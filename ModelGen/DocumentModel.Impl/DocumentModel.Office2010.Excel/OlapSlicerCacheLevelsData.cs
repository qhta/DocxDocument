namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the OlapSlicerCacheLevelsData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IOlapSlicerCacheLevelData))]
public class OlapSlicerCacheLevelsData: IOlapSlicerCacheLevelsData
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
