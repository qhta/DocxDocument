namespace DocumentModel.Drawing;

/// <summary>
/// Scatter Charts.
/// </summary>
public interface IScatterChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public ScatterStyleKind? ScatterStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<IScatterChartSeries>? ScatterChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public IScatterChartExtensionList? ScatterChartExtensionList { get ; set; }
  
}
