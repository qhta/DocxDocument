namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevisionStateLink Class.
/// </summary>
public class RevisionStateLink: IRevisionStateLink
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
