namespace DocumentModel.Drawings;
/// <summary>
///   Represents line formatting properties, including width, cap, compound type, alignment, fill, dash, join, end properties, and extensions.
/// </summary>
[OpenXmlType(typeof(DXD.LinePropertiesType))]
[XmlRoot("LineProperties", Namespace = "DocumentModel.Drawings")]
public partial class LineProperties : ElementCollection<ModelElement>, ILinePropertiesExtendableElement
{
 /// <summary>
 ///   Specifies the line width in EMUs.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.LinePropertiesType.Width))]
 public Int32? Width { get; set; }

 /// <summary>
 ///   Specifies the line cap type (e.g., flat, round, square).
 /// </summary>
 [OpenXmlProperty(nameof(DXD.LinePropertiesType.CapType))]
 public LineCap? CapType { get; set; }

 /// <summary>
 ///   Specifies the compound line type (e.g., single, double, triple).
 /// </summary>
 [OpenXmlProperty(nameof(DXD.LinePropertiesType.CompoundLineType))]
 public CompoundLine? CompoundLineType { get; set; }

 /// <summary>
 ///   Specifies the pen alignment for the line.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.LinePropertiesType.Alignment))]
 public PenAlignment? Alignment { get; set; }

 /// <summary>
 ///   Specifies the fill properties for the line.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Fill))]
 public Fill? Fill { get; set; }

 /// <summary>
 ///   Specifies the preset dash style for the line.
 /// </summary>
 [OpenXmlElement(typeof(DXD.PresetDash))]
 public PresetLineDash? PresetDash { get; set; }

 /// <summary>
 ///   Specifies the custom dash pattern for the line.
 /// </summary>
 [OpenXmlElement(typeof(DXD.CustomDash))]
 public CustomDash? CustomDash { get; set; }

 /// <summary>
 ///   Indicates that a round line join is used.
 /// </summary>
 [DefaultValue(false)]
 /// <summary>
 ///   Indicates that a round line join is used.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Round))]
 public Boolean Round { get; set; }

 /// <summary>
 ///   Indicates that an angle (bevel) joint is used to connect lines.
 /// </summary>
 [DefaultValue(false)]
 /// <summary>
 ///   Indicates that an angle (bevel) joint is used to connect lines.
 /// </summary>
 [OpenXmlElement(typeof(DXD.LineJoinBevel))]
 public Boolean LineJoinBevel { get; set; }

 /// <summary>
 ///   Specifies that a line join shall be mitered.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Miter))]
 public Miter? Miter { get; set; }

 /// <summary>
 ///   Specifies properties for the head end of the line.
 /// </summary>
 [OpenXmlElement(typeof(DXD.HeadEnd))]
 public LineEndPropertiesType? HeadEnd { get; set; }

 /// <summary>
 ///   Specifies properties for the tail end of the line.
 /// </summary>
 [OpenXmlElement(typeof(DXD.TailEnd))]
 public LineEndPropertiesType? TailEnd { get; set; }

 /// <summary>
 ///   Specifies the extension list for additional line properties.
 /// </summary>
 [OpenXmlElement(typeof(DXD.LinePropertiesExtensionList))]
 public LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
}