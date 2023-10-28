namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Bubble Charts.
/// </summary>
public partial class BubbleChart
{
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.Bubble3D? Bubble3D { get; set; }
  
  public UInt32? BubbleScale { get; set; }
  
  public DMDC.ShowNegativeBubbles? ShowNegativeBubbles { get; set; }
  
  public DMDC.SizeRepresentsKind? SizeRepresents { get; set; }
  
  public DMDC.BubbleChartExtensionList? BubbleChartExtensionList { get; set; }
  
}
