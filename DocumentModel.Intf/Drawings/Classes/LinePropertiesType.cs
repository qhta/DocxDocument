namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LinePropertiesType Class.
/// </summary>
public class LinePropertiesType: ModelElement
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