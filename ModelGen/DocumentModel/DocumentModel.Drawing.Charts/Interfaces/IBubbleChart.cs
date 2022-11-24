namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bubble Charts.
/// </summary>
public interface IBubbleChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
