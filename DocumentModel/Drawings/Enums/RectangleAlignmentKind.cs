namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IRectangle Alignments
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RectangleAlignmentKind
{
  /// <summary>
  ///   IRectangle Alignment Enum ( Top Left ).
  /// </summary>
  TopLeft,

  /// <summary>
  ///   IRectangle Alignment Enum ( Top ).
  /// </summary>
  Top,

  /// <summary>
  ///   IRectangle Alignment Enum ( Top Right ).
  /// </summary>
  TopRight,

  /// <summary>
  ///   IRectangle Alignment Enum ( Left ).
  /// </summary>
  Left,

  /// <summary>
  ///   IRectangle Alignment Enum ( Center ).
  /// </summary>
  Center,

  /// <summary>
  ///   IRectangle Alignment Enum ( Right ).
  /// </summary>
  Right,

  /// <summary>
  ///   IRectangle Alignment Enum ( Bottom Left ).
  /// </summary>
  BottomLeft,

  /// <summary>
  ///   IRectangle Alignment Enum ( Bottom ).
  /// </summary>
  Bottom,

  /// <summary>
  ///   IRectangle Alignment Enum ( Bottom Right ).
  /// </summary>
  BottomRight
}
