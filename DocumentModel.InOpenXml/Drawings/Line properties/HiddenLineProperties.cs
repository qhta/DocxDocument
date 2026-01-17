namespace DocumentModel.Drawings;

/// <summary>
/// Represents hidden line properties for a drawing element, including width, cap, compound type, alignment, fill, dash, join, end properties, and extensions.
/// </summary>
public class HiddenLineProperties : ModelElement<DXO10D.HiddenLineProperties>, ILinePropertiesExtendableElement
{
  /// <summary>
  /// Specifies the line width in EMUs.
  /// </summary>
  public Int32? Width { get; set; }

  /// <summary>
  /// Specifies the line cap type (e.g., flat, round, square).
  /// </summary>
  public LineCapKind? CapType { get; set; }

  /// <summary>
  /// Specifies the compound line type (e.g., single, double, triple).
  /// </summary>
  public CompoundLineKind? CompoundLineType { get; set; }

  /// <summary>
  /// Specifies the pen alignment for the line.
  /// </summary>
  public PenAlignmentKind? Alignment { get; set; }

  /// <summary>
  /// Specifies the fill formatting for the line.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  /// Specifies the preset dash style for the line.
  /// </summary>
  public PresetLineDashKind? PresetDash { get; set; }

  /// <summary>
  /// Specifies the custom dash pattern for the line.
  /// </summary>
  public CustomDash? CustomDash { get; set; }

  /// <summary>
  /// Indicates that a round line join is used.
  /// </summary>
  public bool? Round { get; set; }

  /// <summary>
  /// Indicates that an angle (bevel) joint is used to connect lines.
  /// </summary>
  public bool? LineJoinBevel { get; set; }

  /// <summary>
  /// Specifies that a line join shall be mitered.
  /// </summary>
  public Miter? Miter { get; set; }

  /// <summary>
  /// Specifies properties for the head end of the line.
  /// </summary>
  public LineEndPropertiesType? HeadEnd { get; set; }

  /// <summary>
  /// Specifies properties for the tail end of the line.
  /// </summary>
  public LineEndPropertiesType? TailEnd { get; set; }

  /// <summary>
  /// Specifies the extension list for additional line properties.
  /// </summary>
  public LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
}