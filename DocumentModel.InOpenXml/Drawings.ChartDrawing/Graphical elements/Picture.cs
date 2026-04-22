namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes a picture element in chart drawings, including macro references, publishing options, non-visual properties, fill formatting, shape formatting, and style settings.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill"/> <c>&lt;cdr:blipFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties"/> <c>&lt;cdr:spPr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.Style"/> <c>&lt;cdr:style&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties"/> <c>&lt;cdr:nvPicPr&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXDCD.Picture))]
[XmlRoot("Picture", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public class Picture : ModelElement<DXDCD.Picture>
{
 /// <summary>
 /// Macro name or reference for custom functionality associated with the picture.
 /// </summary>
 [OpenXmlProperty(nameof(DXDCD.Picture.Macro))]
 public string? Macro { get => _Macro; set => UpdateField(ref _Macro, value, nameof(Macro)); }
 private string? _Macro;

 /// <summary>
 /// Indicates whether the picture should be published to a server or external destination.
 /// </summary>
 [OpenXmlProperty(nameof(DXDCD.Picture.Published))]
 public bool? Published { get => _Published; set => UpdateField(ref _Published, value, nameof(Published)); }
 private bool? _Published;

 /// <summary>
 /// Style settings applied to the picture for appearance customization.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.Style))]
 public Style? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }
 private Style? _Style;

 /// <summary>
 /// Non-visual properties for the picture, including identifiers, names, and metadata.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.NonVisualPictureProperties))]
 public NonVisualPictureProperties? NonVisualPictureProperties { get => _NonVisualPictureProperties; set => UpdateField(ref _NonVisualPictureProperties, value, nameof(NonVisualPictureProperties)); }
 private NonVisualPictureProperties? _NonVisualPictureProperties;

 /// <summary>
 /// Fill formatting for the picture.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.BlipFill))]
 public BlipFill? BlipFill { get => _BlipFill; set => UpdateField(ref _BlipFill, value, nameof(BlipFill)); }
 private BlipFill? _BlipFill;

 /// <summary>
 /// Shape properties for the picture, including geometry, transformations, and visual effects.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }
 private ShapeProperties? _ShapeProperties;
}