namespace DocumentModel.Drawings;
/// <summary>
///   Represents line formatting properties, including width, cap, compound type, alignment, fill, dash, join, end properties, and extensions.
/// </summary>
[OpenXmlType(typeof(DXD.LinePropertiesType))]
[DataContract]
[XmlRoot("LineProperties", Namespace = "DocumentModel.Drawings")]
public partial class LineProperties : ElementCollection<ModelElement>, ILinePropertiesExtendableElement
{
  /// <summary>
  ///   Specifies the line width in EMUs.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.LinePropertiesType.Width))]
  public Int32? Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Specifies the line cap type (e.g., flat, round, square).
  /// </summary>
  [OpenXmlProperty(nameof(DXD.LinePropertiesType.CapType))]
  public LineCap? CapType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Specifies the compound line type (e.g., single, double, triple).
  /// </summary>
  [OpenXmlProperty(nameof(DXD.LinePropertiesType.CompoundLineType))]
  public CompoundLine? CompoundLineType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Specifies the pen alignment for the line.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.LinePropertiesType.Alignment))]
  public PenAlignment? Alignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Specifies the fill properties for the line.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Fill))]
  public Fill? Fill { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Specifies the preset dash style for the line.
  /// </summary>
  [OpenXmlElement(typeof(DXD.PresetDash))]
  public PresetLineDash? PresetDash { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Specifies the custom dash pattern for the line.
  /// </summary>
  [OpenXmlElement(typeof(DXD.CustomDash))]
  public CustomDash? CustomDash { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Indicates that a round line join is used.
  /// </summary>
  [DefaultValue(false)]
  [OpenXmlElement(typeof(DXD.Round))]
  public Boolean Round { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Indicates that an angle (bevel) joint is used to connect lines.
  /// </summary>
  [DefaultValue(false)]
  [OpenXmlElement(typeof(DXD.LineJoinBevel))]
  public Boolean LineJoinBevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Specifies that a line join shall be mitered.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Miter))]
  public Miter? Miter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Specifies properties for the head end of the line.
  /// </summary>
  [OpenXmlElement(typeof(DXD.HeadEnd))]
  public LineEndPropertiesType? HeadEnd { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Specifies properties for the tail end of the line.
  /// </summary>
  [OpenXmlElement(typeof(DXD.TailEnd))]
  public LineEndPropertiesType? TailEnd { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Specifies the extension list for additional line properties.
  /// </summary>
  [OpenXmlElement(typeof(DXD.LinePropertiesExtensionList))]
  public LinePropertiesExtensionList? LinePropertiesExtensionList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}