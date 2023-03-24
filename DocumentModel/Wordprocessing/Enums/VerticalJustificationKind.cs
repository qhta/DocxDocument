namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VerticalJustificationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalJustificationKind
{
  /// <summary>
  ///   Align Top.
  /// </summary>
  Top,

  /// <summary>
  ///   Align Center.
  /// </summary>
  Center,

  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  Both,

  /// <summary>
  ///   Align Bottom.
  /// </summary>
  Bottom
}