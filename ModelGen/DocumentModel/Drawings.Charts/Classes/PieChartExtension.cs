namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PieChartExtension Class.
/// </summary>
public partial class PieChartExtension
{
  
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredPieSeries? FilteredPieSeries { get; set; }
  
}
