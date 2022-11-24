namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
public interface IScatterChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public IScatterStyle? ScatterStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
