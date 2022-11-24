namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Doughnut Charts.
/// </summary>
public interface IDoughnutChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
