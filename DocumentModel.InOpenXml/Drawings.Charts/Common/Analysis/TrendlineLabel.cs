namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents the label for a trendline in a chart.
///   The trendline label provides additional information, formatting, and layout options for displaying the trendline's equation, name, or other details on the chart.
/// </summary>
[OpenXmlType(typeof(DXDC.TrendlineLabel))]
[DataContract]
[XmlRoot("TrendlineLabel", Namespace = "DocumentModel.Drawings.Charts")]
public partial class TrendlineLabel : ModelElement<DXDC.TrendlineLabel>
{
 /// <summary>
 ///   Layout configuration for the trendline label, controlling its position and alignment within the chart area.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Layout))]
 public Layout? Layout { get => _Layout; set => UpdateField(ref _Layout, value, nameof(Layout)); }
 private Layout? _Layout;

 /// <summary>
 ///   Text content and formatting for the trendline label.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ChartText))]
 public ChartText? ChartText { get => _ChartText; set => UpdateField(ref _ChartText, value, nameof(ChartText)); }
 private ChartText? _ChartText;

 /// <summary>
 ///   Number format applied to values displayed in the trendline label.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.NumberingFormat))]
 public NumberingFormat? NumberingFormat { get => _NumberingFormat; set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat)); }
 private NumberingFormat? _NumberingFormat;

 /// <summary>
 ///   Visual and shape properties for the trendline label.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ChartShapeProperties))]
 public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }
 private ChartShapeProperties? _ChartShapeProperties;

 /// <summary>
 ///   Text formatting and style properties for the trendline label.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.TextProperties))]
 public TextProperties? TextProperties { get => _TextProperties; set => UpdateField(ref _TextProperties, value, nameof(TextProperties)); }
 private TextProperties? _TextProperties;

 /// <summary>
 ///   Collection of extension elements for additional customization of the trendline label.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ExtensionList))]
 public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private IExtensionList? _ExtensionList;
}