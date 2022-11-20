namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageSize Class.
/// </summary>
public class PageSize: IPageSize
{
  /// <summary>
  /// Page Width
  /// </summary>
  public uint? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Height
  /// </summary>
  public uint? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Orientation
  /// </summary>
  public PageOrientationValues? Orient
  {
    get;
    set;
  }
  
  /// <summary>
  /// Printer Paper Code
  /// </summary>
  public ushort? Code
  {
    get;
    set;
  }
  
}
