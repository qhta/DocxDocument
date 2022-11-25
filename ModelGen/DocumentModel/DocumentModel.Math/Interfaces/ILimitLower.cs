namespace DocumentModel.Math;

/// <summary>
/// Lower-Limit Function.
/// </summary>
public interface ILimitLower // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Lower Limit Properties.
  /// </summary>
  public DocumentModel.Math.ILimitLowerProperties? LimitLowerProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? Base { get ; set; }
  
  /// <summary>
  /// Limit (Lower).
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? Limit { get ; set; }
  
}
