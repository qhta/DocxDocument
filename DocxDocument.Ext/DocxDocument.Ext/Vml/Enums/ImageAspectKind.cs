namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Image Scaling Behavior
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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