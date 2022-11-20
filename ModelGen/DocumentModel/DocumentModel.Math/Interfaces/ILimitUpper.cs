namespace DocumentModel.Math;

/// <summary>
/// Upper-Limit Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.ILimitUpperProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
[ChildElementInfo(typeof(DocumentModel.Math.ILimit))]
public interface ILimitUpper // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
