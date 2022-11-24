namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Line Charts.
/// </summary>
public interface ILineChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public IGrouping? Grouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
