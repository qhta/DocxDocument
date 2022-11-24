namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Area Charts.
/// </summary>
public interface IArea3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
