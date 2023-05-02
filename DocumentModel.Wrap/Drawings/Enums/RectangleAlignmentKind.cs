namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Rectangle Alignments
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RectangleAlignmentKind
{
  /// <summary>
  ///   Rectangle Alignment Enum ( Top Left ).
  /// </summary>
  TopLeft,

  /// <summary>
  ///   Rectangle Alignment Enum ( Top ).
  /// </summary>
  Top,

  /// <summary>
  ///   Rectangle Alignment Enum ( Top Right ).
  /// </summary>
  TopRight,

  /// <summary>
  ///   Rectangle Alignment Enum ( Left ).
  /// </summary>
  Left,

  /// <summary>
  ///   Rectangle Alignment Enum ( Center ).
  /// </summary>
  Center,

  /// <summary>
  ///   Rectangle Alignment Enum ( Right ).
  /// </summary>
  Right,

  /// <summary>
  ///   Rectangle Alignment Enum ( Bottom Left ).
  /// </summary>
  BottomLeft,

  /// <summary>
  ///   Rectangle Alignment Enum ( Bottom ).
  /// </summary>
  Bottom,

  /// <summary>
  ///   Rectangle Alignment Enum ( Bottom Right ).
  /// </summary>
  BottomRight
}