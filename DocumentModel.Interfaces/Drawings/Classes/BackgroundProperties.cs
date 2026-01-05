namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BackgroundProperties interface.
/// </summary>
public interface BackgroundProperties:
{
  /// <summary>
  ///   bwMode
  /// </summary>
  public BlackWhiteMode? Mode { get; set; }
  /// <summary>
  ///   bwPure
  /// </summary>
  public BlackWhiteMode? Pure { get; set; }
  /// <summary>
  ///   bwNormal
  /// </summary>
  public BlackWhiteMode? Normal { get; set; }
  /// <summary>
  ///   targetScreenSize
  /// </summary>
  public TargetScreenSize? TargetScreenSize { get; set; }
}