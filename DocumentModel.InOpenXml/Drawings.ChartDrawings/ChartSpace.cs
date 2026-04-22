namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the complete chart space container that encapsulates all chart elements and their configurations.
/// </summary>
/// <remarks>
///   This class defines the root container for a chart drawing
///   that encompasses the entire chart structure including data sources, visual representation, styling, and
///   output settings. The chart space serves as the top-level wrapper that combines the chart data configuration,
///   the chart visualization itself, global styling properties, text formatting, color mappings, format overrides,
///   print settings, and extensibility support. This provides a complete and self-contained chart package that
///   can be embedded in Office documents, presentations, and spreadsheets. The chart space coordinates all aspects
///   of chart creation, rendering, and output, ensuring consistent behavior across different contexts and output
///   formats. It represents the entire chart object as stored in Office documents, maintaining all information
///   needed to render, edit, and reproduce the chart accurately.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.ChartSpace))]
[XmlRoot("ChartSpace", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class ChartSpace : ModelElement<DXO16DCD.ChartSpace>
{
 /// <summary>
 /// Specifies the chart data.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ChartSpace.ChartData))]
 public ChartData? ChartData { get => _ChartData; set => UpdateField(ref _ChartData, value, nameof(ChartData)); }
 private ChartData? _ChartData;

 /// <summary>
 /// Specifies the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ChartSpace.Chart))]
 public Chart? Chart { get => _Chart; set => UpdateField(ref _Chart, value, nameof(Chart)); }
 private Chart? _Chart;

 /// <summary>
 /// Specifies the shape properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ChartSpace.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }
 private ShapeProperties? _ShapeProperties;

 /// <summary>
 /// Specifies the tx pr text body.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ChartSpace.TxPrTextBody))]
 public TxPrTextBody? TxPrTextBody { get => _TxPrTextBody; set => UpdateField(ref _TxPrTextBody, value, nameof(TxPrTextBody)); }
 private TxPrTextBody? _TxPrTextBody;

 /// <summary>
 /// Specifies the color mapping type.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ChartSpace.ColorMappingType))]
 public ColorMappingType? ColorMappingType { get => _ColorMappingType; set => UpdateField(ref _ColorMappingType, value, nameof(ColorMappingType)); }
 private ColorMappingType? _ColorMappingType;

 /// <summary>
 /// Specifies the format overrides.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ChartSpace.FormatOverrides))]
 public FormatOverrides? FormatOverrides { get => _FormatOverrides; set => UpdateField(ref _FormatOverrides, value, nameof(FormatOverrides)); }
 private FormatOverrides? _FormatOverrides;

 /// <summary>
 /// Specifies the print settings.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ChartSpace.PrintSettings))]
 public PrintSettings? PrintSettings { get => _PrintSettings; set => UpdateField(ref _PrintSettings, value, nameof(PrintSettings)); }
 private PrintSettings? _PrintSettings;

 /// <summary>
 /// Specifies the extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ChartSpace.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}