namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Margins.
/// </summary>
public class PageMargins: IPageMargins
{
  /// <summary>
  /// Left Page Margin
  /// </summary>
  public double? Left
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Page Margin
  /// </summary>
  public double? Right
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top Page Margin
  /// </summary>
  public double? Top
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Page Margin
  /// </summary>
  public double? Bottom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Header Page Margin
  /// </summary>
  public double? Header
  {
    get;
    set;
  }
  
  /// <summary>
  /// Footer Page Margin
  /// </summary>
  public double? Footer
  {
    get;
    set;
  }
  
}
