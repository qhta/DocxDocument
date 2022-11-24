namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public interface IOfPieChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public IOfPieType? OfPieType { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
