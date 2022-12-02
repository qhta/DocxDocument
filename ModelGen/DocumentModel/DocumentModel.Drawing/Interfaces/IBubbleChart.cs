namespace DocumentModel.Drawing;

/// <summary>
/// Bubble Charts.
/// </summary>
public interface IBubbleChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IBubbleChartSeries>? BubbleChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public System.Boolean? Bubble3D { get ; set; }
  
  public System.UInt32? BubbleScale { get ; set; }
  
  public System.Boolean? ShowNegativeBubbles { get ; set; }
  
  public DocumentModel.Drawing.SizeRepresentsKind? SizeRepresents { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.IBubbleChartExtensionList? BubbleChartExtensionList { get ; set; }
  
}
