namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PenAlignmentValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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