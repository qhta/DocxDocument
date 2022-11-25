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
  
}
