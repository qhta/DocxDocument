namespace DocumentModel.Wordprocessing;

/// <summary>
/// Web Page Settings.
/// </summary>
public class WebSettings
{
  /// <summary>
  /// Frameset.
  /// </summary>
  public Frameset? Frameset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Divs.
  /// </summary>
  public Divs? Divs
  {
    get;
    set;
  }
  
  /// <summary>
  /// TargetScreenSize.
  /// </summary>
  public TargetScreenSizeKind? TargetScreenSize
  {
    get;
    set;
  }
  
}
