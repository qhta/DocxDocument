namespace DocumentModel.Drawings;
/// <summary>
/// Represents hidden line properties for a drawing element, including width, cap, compound type, alignment, fill, dash, join, end properties, and extensions.
/// </summary>
[OpenXmlType(typeof(DXO10D.HiddenLineProperties))]
public partial class HiddenLineProperties : ModelElement<DXO10D.HiddenLineProperties>, ILinePropertiesExtendableElement
{
 /// <summary>
 /// Specifies the line width in EMUs.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.HiddenLineProperties.Width))]
 public Int32? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }
 private Int32? _Width;
 /// <summary>
 /// Specifies the line cap type (e.g., flat, round, square).
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.HiddenLineProperties.CapType))]
 public LineCap? CapType { get => _CapType; set => UpdateField(ref _CapType, value, nameof(CapType)); }
 private LineCap? _CapType;
 /// <summary>
 /// Specifies the compound line type (e.g., single, double, triple).
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.HiddenLineProperties.CompoundLineType))]
 public CompoundLine? CompoundLineType { get => _CompoundLineType; set => UpdateField(ref _CompoundLineType, value, nameof(CompoundLineType)); }
 private CompoundLine? _CompoundLineType;
 /// <summary>
 /// Specifies the pen alignment for the line.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.HiddenLineProperties.Alignment))]
 public PenAlignment? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }
 private PenAlignment? _Alignment;
 /// <summary>
 /// Specifies the fill formatting for the line.
 /// </summary>
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }
 private Fill? _Fill;
 /// <summary>
 /// Specifies the preset dash style for the line.
 /// </summary>
 public PresetLineDashes? PresetDash { get => _PresetDash; set => UpdateField(ref _PresetDash, value, nameof(PresetDash)); }
 private PresetLineDashes? _PresetDash;
 /// <summary>
 /// Specifies the custom dash pattern for the line.
 /// </summary>
 public CustomDash? CustomDash { get => _CustomDash; set => UpdateField(ref _CustomDash, value, nameof(CustomDash)); }
 private CustomDash? _CustomDash;
 /// <summary>
 /// Indicates that a round line join is used.
 /// </summary>
 public bool? Round { get => _Round; set => UpdateField(ref _Round, value, nameof(Round)); }
 private bool? _Round;
 /// <summary>
 /// Indicates that an angle (bevel) joint is used to connect lines.
 /// </summary>
 public bool? LineJoinBevel { get => _LineJoinBevel; set => UpdateField(ref _LineJoinBevel, value, nameof(LineJoinBevel)); }
 private bool? _LineJoinBevel;
 /// <summary>
 /// Specifies that a line join shall be mitered.
 /// </summary>
 public Miter? Miter { get => _Miter; set => UpdateField(ref _Miter, value, nameof(Miter)); }
 private Miter? _Miter;
 /// <summary>
 /// Specifies properties for the head end of the line.
 /// </summary>
 public LineEndPropertiesType? HeadEnd { get => _HeadEnd; set => UpdateField(ref _HeadEnd, value, nameof(HeadEnd)); }
 private LineEndPropertiesType? _HeadEnd;
 /// <summary>
 /// Specifies properties for the tail end of the line.
 /// </summary>
 public LineEndPropertiesType? TailEnd { get => _TailEnd; set => UpdateField(ref _TailEnd, value, nameof(TailEnd)); }
 private LineEndPropertiesType? _TailEnd;
 /// <summary>
 /// Specifies the extension list for additional line properties.
 /// </summary>
 public LinePropertiesExtensionList? LinePropertiesExtensionList { get => _LinePropertiesExtensionList; set => UpdateField(ref _LinePropertiesExtensionList, value, nameof(LinePropertiesExtensionList)); }
 private LinePropertiesExtensionList? _LinePropertiesExtensionList;
}