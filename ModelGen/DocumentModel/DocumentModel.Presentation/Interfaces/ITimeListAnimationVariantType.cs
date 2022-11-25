namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TimeListAnimationVariantType Class.
/// </summary>
public interface ITimeListAnimationVariantType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Boolean Variant.
  /// </summary>
  public System.Boolean? BooleanVariantValue { get ; set; }
  
  /// <summary>
  /// Integer.
  /// </summary>
  public System.Int32? IntegerVariantValue { get ; set; }
  
  /// <summary>
  /// Float Value.
  /// </summary>
  public System.Single? FloatVariantValue { get ; set; }
  
  /// <summary>
  /// String Value.
  /// </summary>
  public System.String? StringVariantValue { get ; set; }
  
  /// <summary>
  /// Color Value.
  /// </summary>
  public DocumentModel.Presentation.IColorType? ColorValue { get ; set; }
  
}
