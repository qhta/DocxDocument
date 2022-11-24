namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Pie Charts.
/// </summary>
public interface IPieChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
