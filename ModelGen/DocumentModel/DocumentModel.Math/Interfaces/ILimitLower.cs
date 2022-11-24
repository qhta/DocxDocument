namespace DocumentModel.Math;

/// <summary>
/// Lower-Limit Function.
/// </summary>
public interface ILimitLower // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Lower Limit Properties.
  /// </summary>
  public ILimitLowerProperties? LimitLowerProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
  /// <summary>
  /// Limit (Lower).
  /// </summary>
  public ILimit? Limit { get ; set; }
  
}
