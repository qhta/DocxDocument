namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Line Charts.
/// </summary>
public interface ILine3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
