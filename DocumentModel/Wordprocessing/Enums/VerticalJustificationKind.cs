namespace DocumentModel.Wordprocessing;

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