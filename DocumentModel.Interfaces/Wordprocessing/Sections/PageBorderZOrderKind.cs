namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PageBorderZOrderValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageBorderZOrderKind
{
  /// <summary>
  ///   Page Border Ahead of Text.
  /// </summary>
  Front,
  /// <summary>
  ///   Page Border Behind Text.
  /// </summary>
  Back
}