namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public interface IOfPieChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public DocumentModel.Drawing.Charts.OfPieKind? OfPieType { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
}
