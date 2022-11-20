namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DateAxExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.INumberingFormat))]
public class DateAxExtension: IDateAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
