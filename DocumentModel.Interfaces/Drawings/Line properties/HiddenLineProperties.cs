namespace DocumentModel.Drawings;

/// <summary>
///   Represents hidden line properties for a drawing element, including width, cap, compound type, alignment, fill, dash, join, end properties, and extensions.
/// </summary>
public interface HiddenLineProperties : LinePropertiesExtendableElement
{
  /// <summary>
  ///   Line width.
  /// </summary>
  public Int32? Width { get; set; }

  /// <summary>
  ///   Line cap type.
  /// </summary>
  public LineCapKind? CapType { get; set; }

  /// <summary>
  ///   Compound line type.
  /// </summary>
  public CompoundLineKind? CompoundLineType { get; set; }

  /// <summary>
  ///   Pen alignment.
  /// </summary>
  public PenAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Fill formatting for the line.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  ///   Preset dash style for the line.
  /// </summary>
  public PresetLineDashKind? PresetDash { get; set; }

  /// <summary>
  ///   Custom dash pattern for the line.
  /// </summary>
  public CustomDash? CustomDash { get; set; }

  /// <summary>
  ///   Indicates a round line join.
  /// </summary>
  public bool? Round { get; set; }

  /// <summary>
  ///   Indicates an angle (bevel) joint is used to connect lines.
  /// </summary>
  public bool? LineJoinBevel { get; set; }

  /// <summary>
  ///   Specifies that a line join shall be mitered.
  /// </summary>
  public Miter? Miter { get; set; }

  /// <summary>
  ///   Properties for the head end of the line.
  /// </summary>
  public LineEndPropertiesType? HeadEnd { get; set; }

  /// <summary>
  ///   Properties for the tail end of the line.
  /// </summary>
  public LineEndPropertiesType? TailEnd { get; set; }

}