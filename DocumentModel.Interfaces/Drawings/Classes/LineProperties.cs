namespace DocumentModel.Drawings;
/// <summary>
///   Defines the LinePropertiesType Class.
/// </summary>
public class LineProperties: ITypedModelElement, IDrawingProperty
{
  /// <summary>
  ///   Line width
  /// </summary>
  public Int32? Width { get; set; }
  /// <summary>
  ///   Line cap
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
  /// Line fill properties
  /// </summary>
  public Fill? Fill { get; set; }
  /// <summary>
  /// Line preset dash properties
  /// </summary>
  public PresetLineDashKind? PresetDash { get; set; }
  /// <summary>
  /// Line custom dash properties
  /// </summary>
  public CustomDash? CustomDash { get; set; }
  /// <summary>
  /// Round Line Join.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Round { get; set; }
  /// <summary>
  /// Angle joint is used to connect lines.
  /// </summary>
  [DefaultValue(false)]
  public Boolean LineJoinBevel { get; set; }
  /// <summary>
  /// This element specifies that a line join shall be mitered.
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
  /// <remarks>Use this property to store or retrieve additional custom properties associated with the line that
  /// are not defined in the standard schema. This is typically used for extensibility scenarios.</remarks>
  public LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
}