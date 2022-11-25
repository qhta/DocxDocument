namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Radar Charts.
/// </summary>
public interface IRadarChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public DocumentModel.Drawing.Charts.RadarStyleKind? RadarStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
}
