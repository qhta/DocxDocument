namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Legend data and formatting.
/// </summary>
public interface ILegend // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Legend Position.
  /// </summary>
  public DocumentModel.Drawing.Charts.LegendPositionKind? LegendPosition { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ILegendEntry>? LegendEntries { get ; set; }
  
  public DocumentModel.Drawing.Charts.ILayout? Layout { get ; set; }
  
  public System.Boolean? Overlay { get ; set; }
  
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.ITextProperties? TextProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
