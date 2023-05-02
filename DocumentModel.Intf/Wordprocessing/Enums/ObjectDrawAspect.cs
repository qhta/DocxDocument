namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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