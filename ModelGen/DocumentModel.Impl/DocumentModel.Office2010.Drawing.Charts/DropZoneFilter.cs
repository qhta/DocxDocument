namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the DropZoneFilter Class.
/// </summary>
public class DropZoneFilter: IDropZoneFilter
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
