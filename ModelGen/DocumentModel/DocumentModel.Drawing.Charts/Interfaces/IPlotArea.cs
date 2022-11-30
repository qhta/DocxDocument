namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Plot data and formatting.
/// </summary>
public interface IPlotArea // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawing.Charts.ILayout? Layout { get ; set; }
  
  public DocumentModel.Drawing.Charts.IAreaChart? AreaChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IArea3DChart? Area3DChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.ILineChart? LineChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.ILine3DChart? Line3DChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IStockChart? StockChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IRadarChart? RadarChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IScatterChart? ScatterChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IPieChart? PieChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IPie3DChart? Pie3DChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDoughnutChart? DoughnutChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IBarChart? BarChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IBar3DChart? Bar3DChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IOfPieChart? OfPieChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.ISurfaceChart? SurfaceChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.ISurface3DChart? Surface3DChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IBubbleChart? BubbleChart { get ; set; }
  
  public DocumentModel.Drawing.Charts.IValueAxis? ValueAxis { get ; set; }
  
  public DocumentModel.Drawing.Charts.ICategoryAxis? CategoryAxis { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDateAxis? DateAxis { get ; set; }
  
  public DocumentModel.Drawing.Charts.ISeriesAxis? SeriesAxis { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataTable? DataTable { get ; set; }
  
  public DocumentModel.Drawing.Charts.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
