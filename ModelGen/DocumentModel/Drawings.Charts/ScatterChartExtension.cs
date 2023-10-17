namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ScatterChartExtension Class.
/// </summary>
public partial class ScatterChartExtension
{
  
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredScatterSeries? FilteredScatterSeries { get; set; }
  
}
