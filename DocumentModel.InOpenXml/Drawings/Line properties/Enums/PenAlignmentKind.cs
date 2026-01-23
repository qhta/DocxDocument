namespace DocumentModel.Drawings;

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