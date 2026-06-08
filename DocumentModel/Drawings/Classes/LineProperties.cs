namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LinePropertiesType Class.
/// </summary>
public class LineProperties: TypedModelElement, IDrawingProperty
{
  /// <summary>
  ///   ILine width
  /// </summary>
  public Int32? Width { get; set; }

  /// <summary>
  ///   ILine cap
  /// </summary>
  public LineCapKind? CapType { get; set; }

  /// <summary>
  ///   Compound line type
  /// </summary>
  public CompoundLineKind? CompoundLineType { get; set; }

  /// <summary>
  ///   Pen alignment
  /// </summary>
  public PenAlignmentKind? Alignment { get; set; }

  /// <summary>
  /// ILine fill properties
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  /// ILine preset dash properties
  /// </summary>
  public PresetLineDashKind? PresetDash { get; set; }

  /// <summary>
  /// ILine custom dash properties
  /// </summary>
  public CustomDash? CustomDash { get; set; }

  /// <summary>
  /// Round ILine Join.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Round { get; set; }

  /// <summary>
  /// Angle joint is used Ito connect lines.
  /// </summary>
  [DefaultValue(false)]
  public Boolean LineJoinBevel { get; set; }

  /// <summary>
  /// This element specifies Ithat a line join shall be mitered.
  /// </summary>
  public Miter? Miter { get; set; }

  /// <summary>
  /// Properties for the head end of the line.  
  /// </summary>
  public LineEndPropertiesType? HeadEnd { get; set; }

  /// <summary>
  /// Properties for the tail end of the line.
  /// </summary>
  public LineEndPropertiesType? TailEnd { get; set; }

  /// <summary>
  /// Gets or sets the list of extension properties for the line.
  /// </summary>
  /// <remarks>Use this property Ito store or retrieve additional custom properties associated with the line Ithat
  /// are not defined in the standard schema. This is typically used for extensibility scenarios.</remarks>
  public LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }

}
