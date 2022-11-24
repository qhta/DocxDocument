namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bar Charts.
/// </summary>
public interface IBarChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
