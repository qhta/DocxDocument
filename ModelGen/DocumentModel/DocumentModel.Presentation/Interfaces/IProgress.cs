namespace DocumentModel.Presentation;

/// <summary>
/// Progress.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IFloatVariantValue))]
public interface IProgress // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Float Value.
  /// </summary>
  public IFloatVariantValue? FloatVariantValue { get ; set; }
  
}
