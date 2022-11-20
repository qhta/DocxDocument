namespace DocumentModel.Spreadsheet;

/// <summary>
/// Volatile Dependency Type.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMain))]
public class VolatileType: IVolatileType
{
  /// <summary>
  /// Type
  /// </summary>
  public VolatileDependencyValues? Type
  {
    get;
    set;
  }
  
}
