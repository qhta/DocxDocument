namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the HideUnhideSheet Class.
/// </summary>
public class HideUnhideSheet: IHideUnhideSheet
{
  /// <summary>
  /// hide, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Hide
  {
    get;
    set;
  }
  
}
