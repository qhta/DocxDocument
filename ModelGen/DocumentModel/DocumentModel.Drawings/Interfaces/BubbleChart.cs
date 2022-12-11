namespace DocumentModel.Drawings;

/// <summary>
/// Bubble Charts.
/// </summary>
public interface BubbleChart
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<BubbleChartSeries>? BubbleChartSerieses { get ; set; }
  
  public DataLabels? DataLabels { get ; set; }
  
  public Boolean? Bubble3D { get ; set; }
  
  public UInt32? BubbleScale { get ; set; }
  
  public Boolean? ShowNegativeBubbles { get ; set; }
  
  public SizeRepresentsKind? SizeRepresents { get ; set; }
  
  public UInt32? AxisId { get ; set; }
  
  public BubbleChartExtensionList? BubbleChartExtensionList { get ; set; }
  
}
