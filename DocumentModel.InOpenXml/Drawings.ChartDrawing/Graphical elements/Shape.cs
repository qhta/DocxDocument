namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes a shape element in chart drawings, including macro references, text linking, locking options, publishing settings, non-visual and visual properties, style, and text body formatting.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties"/> <c>&lt;cdr:spPr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.Style"/> <c>&lt;cdr:style&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody"/> <c>&lt;cdr:txBody&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties"/> <c>&lt;cdr:nvSpPr&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXDCD.Shape))]
public class Shape: ModelElement<DXDCD.Shape>
{
  /// <summary>
  /// Macro name or reference for custom functionality associated with the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Shape.Macro))]
  public string? Macro { get => _Macro; set => UpdateField(ref _Macro, value, nameof(Macro)); }
  private string? _Macro;
  /// <summary>
  /// Link to external or internal text content for the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Shape.TextLink))]
  public string? TextLink { get => _TextLink; set => UpdateField(ref _TextLink, value, nameof(TextLink)); }
  private string? _TextLink;
  /// <summary>
  /// Indicates whether the text within the shape is locked from editing.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Shape.LockText))]
  public bool? LockText { get => _LockText; set => UpdateField(ref _LockText, value, nameof(LockText)); }
  private bool? _LockText;
  /// <summary>
  /// Indicates whether the shape should be published to a server or external destination.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Shape.Published))]
  public bool? Published { get => _Published; set => UpdateField(ref _Published, value, nameof(Published)); }
  private bool? _Published;
  /// <summary>
  /// Non-visual properties for the shape, including identifiers, names, and metadata.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.NonVisualShapeProperties))]
  public NonVisualShapeProperties? NonVisualShapeProperties
  {
    get => _NonVisualShapeProperties;
    set => UpdateField(ref _NonVisualShapeProperties, value, nameof(NonVisualShapeProperties));
  }
  private NonVisualShapeProperties? _NonVisualShapeProperties;
  /// <summary>
  /// Visual formatting and properties for the shape.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties;
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }
  private ShapeProperties? _ShapeProperties;
  /// <summary>
  /// Style settings applied to the shape for appearance customization.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.Style))]
  public Style? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }
  private Style? _Style;
  /// <summary>
  /// Text body formatting and content for the shape.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.TextBody))]
  public TextBody? TextBody { get => _TextBody; set => UpdateField(ref _TextBody, value, nameof(TextBody)); }
  private TextBody? _TextBody;
}