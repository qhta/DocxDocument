namespace DocumentModel.Drawings;

/// <summary>
///   Represents line formatting properties, including width, cap, compound type, alignment, fill, dash, join, end properties, and extensions.
/// </summary>
public interface LineProperties : LinePropertiesExtendableElement, TypedModelElement, DrawingProperty
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
  ///   Line fill properties.
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
  [DefaultValue(false)]
  public Boolean Round { get; set; }

  /// <summary>
  ///   Indicates an angle (bevel) joint is used to connect lines.
  /// </summary>
  [DefaultValue(false)]
  public Boolean LineJoinBevel { get; set; }

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