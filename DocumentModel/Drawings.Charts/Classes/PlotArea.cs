namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Plot data and formatting.
/// </summary>
public partial class PlotArea
{
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawings.Charts.Layout? Layout { get; set; }
  
  public DocumentModel.Drawings.Charts.AreaChart? AreaChart { get; set; }
  
  public DocumentModel.Drawings.Charts.Area3DChart? Area3DChart { get; set; }
  
  public DocumentModel.Drawings.Charts.LineChart? LineChart { get; set; }
  
  public DocumentModel.Drawings.Charts.Line3DChart? Line3DChart { get; set; }
  
  public DocumentModel.Drawings.Charts.StockChart? StockChart { get; set; }
  
  public DocumentModel.Drawings.Charts.RadarChart? RadarChart { get; set; }
  
  public DocumentModel.Drawings.Charts.ScatterChart? ScatterChart { get; set; }
  
  public DocumentModel.Drawings.Charts.PieChart? PieChart { get; set; }
  
  public DocumentModel.Drawings.Charts.Pie3DChart? Pie3DChart { get; set; }
  
  public DocumentModel.Drawings.Charts.DoughnutChart? DoughnutChart { get; set; }
  
  public DocumentModel.Drawings.Charts.BarChart? BarChart { get; set; }
  
  public DocumentModel.Drawings.Charts.Bar3DChart? Bar3DChart { get; set; }
  
  public DocumentModel.Drawings.Charts.OfPieChart? OfPieChart { get; set; }
  
  public DocumentModel.Drawings.Charts.SurfaceChart? SurfaceChart { get; set; }
  
  public DocumentModel.Drawings.Charts.Surface3DChart? Surface3DChart { get; set; }
  
  public DocumentModel.Drawings.Charts.BubbleChart? BubbleChart { get; set; }
  
  public DocumentModel.Drawings.Charts.ValueAxis? ValueAxis { get; set; }
  
  public DocumentModel.Drawings.Charts.CategoryAxis? CategoryAxis { get; set; }
  
  public DocumentModel.Drawings.Charts.DateAxis? DateAxis { get; set; }
  
  public DocumentModel.Drawings.Charts.SeriesAxis? SeriesAxis { get; set; }
  
  public DocumentModel.Drawings.Charts.DataTable? DataTable { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
