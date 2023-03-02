namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LinePropertiesType Class.
/// </summary>
public record LinePropertiesType
{
  /// <summary>
  ///   line width
  /// </summary>
  public Int32? Width { get; set; }

  /// <summary>
  ///   line cap
  /// </summary>
  public LineCapKind? CapType { get; set; }

  /// <summary>
  ///   compound line type
  /// </summary>
  public CompoundLineKind? CompoundLineType { get; set; }

  /// <summary>
  ///   pen alignment
  /// </summary>
  public PenAlignmentKind? Alignment { get; set; }
}