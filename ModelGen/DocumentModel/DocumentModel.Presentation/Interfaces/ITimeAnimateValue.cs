namespace DocumentModel.Presentation;

/// <summary>
/// Time Animate Value.
/// </summary>
public interface ITimeAnimateValue // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Time
  /// </summary>
  public String? Time { get ; set; }
  
  /// <summary>
  /// Formula
  /// </summary>
  public String? Fomula { get ; set; }
  
  /// <summary>
  /// Value.
  /// </summary>
  public IVariantValue? VariantValue { get ; set; }
  
}
