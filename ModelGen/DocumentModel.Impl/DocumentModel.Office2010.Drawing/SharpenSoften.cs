namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the SharpenSoften Class.
/// </summary>
public class SharpenSoften: ISharpenSoften
{
  /// <summary>
  /// amount, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Amount
  {
    get;
    set;
  }
  
}
