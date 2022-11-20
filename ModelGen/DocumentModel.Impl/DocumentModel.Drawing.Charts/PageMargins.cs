namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Page Margins.
/// </summary>
public class PageMargins: IPageMargins
{
  /// <summary>
  /// Left
  /// </summary>
  public double? Left
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right
  /// </summary>
  public double? Right
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top
  /// </summary>
  public double? Top
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom
  /// </summary>
  public double? Bottom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Header
  /// </summary>
  public double? Header
  {
    get;
    set;
  }
  
  /// <summary>
  /// Footer
  /// </summary>
  public double? Footer
  {
    get;
    set;
  }
  
}
