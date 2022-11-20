namespace DocumentModel.Presentation;

/// <summary>
/// Time Animate Value.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IVariantValue))]
public interface ITimeAnimateValue // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Time
  /// </summary>
  public string? Time { get ; set; }
  
  /// <summary>
  /// Formula
  /// </summary>
  public string? Fomula { get ; set; }
  
  /// <summary>
  /// Value.
  /// </summary>
  public IVariantValue? VariantValue { get ; set; }
  
}
