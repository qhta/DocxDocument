namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ShowMediaControls Class.
/// </summary>
public class ShowMediaControls: IShowMediaControls
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
