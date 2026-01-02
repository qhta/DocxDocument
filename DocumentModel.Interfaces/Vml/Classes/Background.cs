namespace DocumentModel.Vml;

/// <summary>
///   Document Background.
/// </summary>
public class Background: ModelElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public bool? Filled { get; set; }
  /// <summary>
  ///   Fill Color
  /// </summary>
  public string? Fillcolor { get; set; }
  /// <summary>
  ///   Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? BlackWhiteMode { get; set; }
  /// <summary>
  ///   Pure Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? PureBlackWhiteMode { get; set; }
  /// <summary>
  ///   Normal Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? NormalBlackWhiteMode { get; set; }
  /// <summary>
  ///   Target Screen Size
  /// </summary>
  public ScreenSizeKind? TargetScreenSize { get; set; }
  /// <summary>
  ///   Fill.
  /// </summary>
  public IFill? Fill { get; set; }
}