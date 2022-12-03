namespace DocumentModel.Vml;

/// <summary>
/// Image Scaling Behavior
/// </summary>
public enum ImageAspectKind
{
  /// <summary>
  /// Ignore Aspect Ratio.
  /// </summary>
  [XmlEnum("ignore")]
  Ignore,
  
  /// <summary>
  /// At Most.
  /// </summary>
  [XmlEnum("atMost")]
  AtMost,
  
  /// <summary>
  /// At Least.
  /// </summary>
  [XmlEnum("atLeast")]
  AtLeast,
  
}
