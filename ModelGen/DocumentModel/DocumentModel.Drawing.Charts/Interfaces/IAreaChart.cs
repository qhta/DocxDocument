namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Area Charts.
/// </summary>
public interface IAreaChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
