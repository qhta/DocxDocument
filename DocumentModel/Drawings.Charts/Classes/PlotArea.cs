namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Plot data and formatting.
/// </summary>
public class PlotArea: ModelElement
{
  /// <summary>
  ///   Layout.
  /// </summary>
  public Layout? Layout { get; set; }

  public AreaChart? AreaChart { get; set; }

  public Area3DChart? Area3DChart { get; set; }

  public LineChart? LineChart { get; set; }

  public Line3DChart? Line3DChart { get; set; }

  public StockChart? StockChart { get; set; }

  public RadarChart? RadarChart { get; set; }

  public ScatterChart? ScatterChart { get; set; }

  public PieChart? PieChart { get; set; }

  public Pie3DChart? Pie3DChart { get; set; }

  public DoughnutChart? DoughnutChart { get; set; }

  public BarChart? BarChart { get; set; }

  public Bar3DChart? Bar3DChart { get; set; }

  public OfPieChart? OfPieChart { get; set; }

  public SurfaceChart? SurfaceChart { get; set; }

  public Surface3DChart? Surface3DChart { get; set; }

  public BubbleChart? BubbleChart { get; set; }

  public ValueAxis? ValueAxis { get; set; }

  public CategoryAxis? CategoryAxis { get; set; }

  public DateAxis? DateAxis { get; set; }

  public SeriesAxis? SeriesAxis { get; set; }

  public DataTable? DataTable { get; set; }

  public ShapeProperties? ShapeProperties { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}