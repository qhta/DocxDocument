namespace DocumentModel.Vml;

/// <summary>
/// Document Background.
/// </summary>
public class Background
{
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? BlackWhiteMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? PureBlackWhiteMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? NormalBlackWhiteMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  public ScreenSizeKind? TargetScreenSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public Fill? Fill
  {
    get;
    set;
  }
  
}
