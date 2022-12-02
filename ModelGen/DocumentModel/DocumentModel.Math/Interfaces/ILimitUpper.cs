namespace DocumentModel.Math;

/// <summary>
/// Upper-Limit Function.
/// </summary>
public interface ILimitUpper // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Upper Limit Properties.
  /// </summary>
  public ILimitUpperProperties? LimitUpperProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
  /// <summary>
  /// Limit (Upper).
  /// </summary>
  public ILimit? Limit { get ; set; }
  
}
