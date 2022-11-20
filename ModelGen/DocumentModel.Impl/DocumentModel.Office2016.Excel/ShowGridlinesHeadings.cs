namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the ShowGridlinesHeadings Class.
/// </summary>
public class ShowGridlinesHeadings: IShowGridlinesHeadings
{
  /// <summary>
  /// showGridLines, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? ShowGridLines
  {
    get;
    set;
  }
  
  /// <summary>
  /// showRowCol, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? ShowRowCol
  {
    get;
    set;
  }
  
}
