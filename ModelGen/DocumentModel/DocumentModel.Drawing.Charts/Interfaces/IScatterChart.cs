namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
public interface IScatterChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public DocumentModel.Drawing.Charts.ScatterStyleKind? ScatterStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
}
