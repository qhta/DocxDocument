namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Document Background.
/// </summary>
public class Background: ModelElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public Boolean? Filled { get; set; }

  /// <summary>
  ///   Fill Color
  /// </summary>
  public String? Fillcolor { get; set; }

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
  public Fill? Fill { get; set; }
}