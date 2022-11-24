namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Bar Charts.
/// </summary>
public interface IBar3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public IBarDirection? BarDirection { get ; set; }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public IBarGrouping? BarGrouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
