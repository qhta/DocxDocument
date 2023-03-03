namespace DocumentModel.Math;

/// <summary>
///   Defines the HorizontalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HorizontalAlignmentKind
{
  /// <summary>
  ///   Left Justification.
  /// </summary>
  Left,

  /// <summary>
  ///   Center.
  /// </summary>
  Center,

  /// <summary>
  ///   Right.
  /// </summary>
  Right
}