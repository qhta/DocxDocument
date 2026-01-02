namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PenAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PenAlignmentKind
{
  /// <summary>
  ///   ctr.
  /// </summary>
  Center,
  /// <summary>
  ///   in.
  /// </summary>
  Inset
}