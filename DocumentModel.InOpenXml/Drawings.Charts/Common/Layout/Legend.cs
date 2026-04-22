namespace DocumentModel.Drawings.Charts;
/// <summary>
/// Describes legend data and formatting for a chart, including position, entries, layout, overlay, shape formatting, text formatting, and extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.Legend))]
[XmlRoot("Legend", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Legend : ModelElement<DXDC.Legend> //: ExtendableElement
{
 /// <summary>
 /// Specifies the position of the legend within the chart area.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Legend.LegendPosition))]
 public LegendPosition? LegendPosition { get => _LegendPosition; set => UpdateField(ref _LegendPosition, value, nameof(LegendPosition)); }
 private LegendPosition? _LegendPosition;

 /// <summary>
 /// Collection of legend entries representing individual series or data points.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.LegendEntry))]
 public LegendEntries? LegendEntries { get => _LegendEntries; set => UpdateField(ref _LegendEntries, value, nameof(LegendEntries)); }
 private LegendEntries? _LegendEntries;

 /// <summary>
 /// Layout information for the legend, such as size and alignment.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Layout))]
 public Layout? Layout { get => _Layout; set => UpdateField(ref _Layout, value, nameof(Layout)); }
 private Layout? _Layout;

 /// <summary>
 /// Indicates whether the legend overlays the chart area.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Overlay))]
 public bool? Overlay { get => _Overlay; set => UpdateField(ref _Overlay, value, nameof(Overlay)); }
 private bool? _Overlay;

 /// <summary>
 /// Shape formatting and visual properties for the legend background and border.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ChartShapeProperties))]
 public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }
 private ChartShapeProperties? _ChartShapeProperties;

 /// <summary>
 /// Text formatting and properties for legend labels.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.TextProperties))]
 public TextProperties? TextProperties { get => _TextProperties; set => UpdateField(ref _TextProperties, value, nameof(TextProperties)); }
 private TextProperties? _TextProperties;
}