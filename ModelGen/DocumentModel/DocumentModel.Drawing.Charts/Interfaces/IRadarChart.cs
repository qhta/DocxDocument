namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Radar Charts.
/// </summary>
public interface IRadarChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public IRadarStyle? RadarStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
