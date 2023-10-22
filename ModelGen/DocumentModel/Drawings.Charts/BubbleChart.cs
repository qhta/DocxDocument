namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Bubble Charts.
/// </summary>
public partial class BubbleChart
{
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.Bubble3D? Bubble3D { get; set; }
  
  public UInt32? BubbleScale { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowNegativeBubbles? ShowNegativeBubbles { get; set; }
  
  public DocumentModel.Drawings.Charts.SizeRepresentsKind? SizeRepresents { get; set; }
  
  public DocumentModel.Drawings.Charts.BubbleChartExtensionList? BubbleChartExtensionList { get; set; }
  
}
