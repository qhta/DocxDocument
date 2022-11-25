namespace DocumentModel.Math;

/// <summary>
/// Upper-Limit Function.
/// </summary>
public interface ILimitUpper // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Upper Limit Properties.
  /// </summary>
  public DocumentModel.Math.ILimitUpperProperties? LimitUpperProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? Base { get ; set; }
  
  /// <summary>
  /// Limit (Upper).
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? Limit { get ; set; }
  
}
