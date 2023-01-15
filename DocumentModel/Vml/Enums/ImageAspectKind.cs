namespace DocumentModel.Vml;

/// <summary>
///   Image Scaling Behavior
/// </summary>
public enum ImageAspectKind
{
  /// <summary>
  ///   Ignore Aspect Ratio.
  /// </summary>
  Ignore,

  /// <summary>
  ///   At Most.
  /// </summary>
  AtMost,

  /// <summary>
  ///   At Least.
  /// </summary>
  AtLeast
}