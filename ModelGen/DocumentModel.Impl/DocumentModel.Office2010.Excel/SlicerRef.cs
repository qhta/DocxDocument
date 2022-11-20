namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerRef Class.
/// </summary>
public class SlicerRef: ISlicerRef
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
