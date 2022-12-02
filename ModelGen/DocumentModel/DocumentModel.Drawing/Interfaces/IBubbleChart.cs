namespace DocumentModel.Drawing;

/// <summary>
/// Bubble Charts.
/// </summary>
public interface IBubbleChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<IBubbleChartSeries>? BubbleChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public Boolean? Bubble3D { get ; set; }
  
  public UInt32? BubbleScale { get ; set; }
  
  public Boolean? ShowNegativeBubbles { get ; set; }
  
  public SizeRepresentsKind? SizeRepresents { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public IBubbleChartExtensionList? BubbleChartExtensionList { get ; set; }
  
}
