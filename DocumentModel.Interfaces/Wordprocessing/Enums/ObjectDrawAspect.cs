namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ObjectDrawAspect enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ObjectDrawAspect
{
  /// <summary>
  ///   content.
  /// </summary>
  content,
  /// <summary>
  ///   icon.
  /// </summary>
  icon
}