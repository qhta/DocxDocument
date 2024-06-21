namespace ModelDoc;

/// <summary>
/// Content type of the complex type.
/// </summary>
public enum ContentType: byte
{
  /// <summary>
  /// Contains only text.
  /// </summary>
  TextOnly,

  /// <summary>
  /// Complex type element is empty.
  /// </summary>
  Empty,

  /// <summary>
  /// 
  /// </summary>
  ElementOnly,

  /// <summary>
  /// Contains text and elements.
  /// </summary>
  Mixed
}
