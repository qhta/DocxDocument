namespace DocumentModel.Presentation;

/// <summary>
/// Time Animate Value.
/// </summary>
public interface ITimeAnimateValue // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Time
  /// </summary>
  public System.String? Time { get ; set; }
  
  /// <summary>
  /// Formula
  /// </summary>
  public System.String? Fomula { get ; set; }
  
  /// <summary>
  /// Value.
  /// </summary>
  public DocumentModel.Presentation.ITimeListAnimationVariantType? VariantValue { get ; set; }
  
}
