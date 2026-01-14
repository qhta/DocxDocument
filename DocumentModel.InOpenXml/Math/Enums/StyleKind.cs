namespace DocumentModel.Math;

/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StyleKind
{
  /// <summary>
  ///   Plain.
  /// </summary>
  Plain,
  /// <summary>
  ///   Bold.
  /// </summary>
  Bold,
  /// <summary>
  ///   Italic.
  /// </summary>
  Italic,
  /// <summary>
  ///   Bold-Italic.
  /// </summary>
  BoldItalic
}