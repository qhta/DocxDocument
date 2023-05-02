namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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