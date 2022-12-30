namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Bubble Charts.
/// </summary>
public partial class BubbleChart
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.BubbleChartSeries>? BubbleChartSerieses { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public Boolean? Bubble3D { get; set; }
  
  public UInt32? BubbleScale { get; set; }
  
  public Boolean? ShowNegativeBubbles { get; set; }
  
  public DocumentModel.Drawings.Charts.SizeRepresentsKind? SizeRepresents { get; set; }
  
  public Collection<System.UInt32>? AxisIds { get; set; }
  
  public DocumentModel.Drawings.Charts.BubbleChartExtensionList? BubbleChartExtensionList { get; set; }
  
}
