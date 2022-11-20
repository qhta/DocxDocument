namespace DocumentModel.Math;

/// <summary>
/// Lower-Limit Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.ILimitLowerProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
[ChildElementInfo(typeof(DocumentModel.Math.ILimit))]
public interface ILimitLower // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
