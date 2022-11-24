namespace DocumentModel.Presentation;

/// <summary>
/// Progress.
/// </summary>
public interface IProgress // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Float Value.
  /// </summary>
  public IFloatVariantValue? FloatVariantValue { get ; set; }
  
}
