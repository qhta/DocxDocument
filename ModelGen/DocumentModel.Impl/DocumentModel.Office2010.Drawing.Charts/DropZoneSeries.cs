namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the DropZoneSeries Class.
/// </summary>
public class DropZoneSeries: IDropZoneSeries
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
