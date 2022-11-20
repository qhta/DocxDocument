namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the DropZoneData Class.
/// </summary>
public class DropZoneData: IDropZoneData
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
