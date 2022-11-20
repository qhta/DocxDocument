namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageMargin Class.
/// </summary>
public class PageMargin: IPageMargin
{
  /// <summary>
  /// Top Margin Spacing
  /// </summary>
  public int? Top
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Margin Spacing
  /// </summary>
  public uint? Right
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Bottom Spacing
  /// </summary>
  public int? Bottom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Left Margin Spacing
  /// </summary>
  public uint? Left
  {
    get;
    set;
  }
  
  /// <summary>
  /// Spacing to Top of Header
  /// </summary>
  public uint? Header
  {
    get;
    set;
  }
  
  /// <summary>
  /// Spacing to Bottom of Footer
  /// </summary>
  public uint? Footer
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Gutter Spacing
  /// </summary>
  public uint? Gutter
  {
    get;
    set;
  }
  
}
