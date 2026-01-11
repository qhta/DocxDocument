namespace DocumentModel.Vml;

/// <summary>
///   Alignment Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HorizontalRuleAlignmentKind
{
  /// <summary>
  ///   Left Alignment.
  /// </summary>
  Left,
  /// <summary>
  ///   Right Alignment.
  /// </summary>
  Right,
  /// <summary>
  ///   Center Alignment.
  /// </summary>
  Center
}