namespace DocumentModel.Office2016.Drawing.Charts;

/// <summary>
/// Defines the UniqueID Class.
/// </summary>
public class UniqueID: IUniqueID
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
