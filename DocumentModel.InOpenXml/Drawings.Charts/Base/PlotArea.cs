namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents the plot area of a chart, including layout, chart collection, axes, data table, shape properties, and extension list.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties"/> <c>&lt;c:spPr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Area3DChart"/> <c>&lt;c:area3DChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.AreaChart"/> <c>&lt;c:areaChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart"/> <c>&lt;c:bar3DChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.BarChart"/> <c>&lt;c:barChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.BubbleChart"/> <c>&lt;c:bubbleChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis"/> <c>&lt;c:catAx&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.DateAxis"/> <c>&lt;c:dateAx&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart"/> <c>&lt;c:doughnutChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.DataTable"/> <c>&lt;c:dTable&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ExtensionList"/> <c>&lt;c:extLst&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Layout"/> <c>&lt;c:layout&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Line3DChart"/> <c>&lt;c:line3DChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.LineChart"/> <c>&lt;c:lineChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.OfPieChart"/> <c>&lt;c:ofPieChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart"/> <c>&lt;c:pie3DChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.PieChart"/> <c>&lt;c:pieChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.RadarChart"/> <c>&lt;c:radarChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ScatterChart"/> <c>&lt;c:scatterChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.SeriesAxis"/> <c>&lt;c:serAx&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.StockChart"/> <c>&lt;c:stockChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart"/> <c>&lt;c:surface3DChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart"/> <c>&lt;c:surfaceChart&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ValueAxis"/> <c>&lt;c:valAx&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXDC.PlotArea))]
[XmlRoot("PlotArea", Namespace = "DocumentModel.Drawings.Charts")]
public partial class PlotArea : ModelElement<DXDC.PlotArea>
{
 /// <summary>
 ///   Layout configuration for the plot area.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Layout))]
 public Layout? Layout { get => _Layout; set => UpdateField(ref _Layout, value, nameof(Layout)); }

 private Layout? _Layout;
 /// <summary>
 ///   Collection of charts contained in the plot area.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.BarChart))]
 public Charts? Charts { get => _Charts; set => UpdateField(ref _Charts, value, nameof(Charts)); }

 private Charts? _Charts;
 /// <summary>
 ///   List of axes used in the plot area.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.DateAxis))]
 public AxisList? Axes { get => _Axes; set => UpdateField(ref _Axes, value, nameof(Axes)); }

 private AxisList? _Axes;
 /// <summary>
 ///   Data table associated with the plot area.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.DataTable))]
 public DataTable? DataTable { get => _DataTable; set => UpdateField(ref _DataTable, value, nameof(DataTable)); }

 private DataTable? _DataTable;
 /// <summary>
 ///   Shape properties for the plot area.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

 private ShapeProperties? _ShapeProperties;
 /// <summary>
 ///   Extension list for additional plot area properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}