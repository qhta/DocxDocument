namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Alignment Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PenAlignmentKind
{
  /// <summary>
  ///   Center Alignment.
  /// </summary>
  Center,

  /// <summary>
  ///   Inset Alignment.
  /// </summary>
  Insert
}