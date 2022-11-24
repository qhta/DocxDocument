namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TimeListAnimationVariantType Class.
/// </summary>
public interface ITimeListAnimationVariantType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Boolean Variant.
  /// </summary>
  public IBooleanVariantValue? BooleanVariantValue { get ; set; }
  
  /// <summary>
  /// Integer.
  /// </summary>
  public IntegerVariantValue? IntegerVariantValue { get ; set; }
  
  /// <summary>
  /// Float Value.
  /// </summary>
  public IFloatVariantValue? FloatVariantValue { get ; set; }
  
  /// <summary>
  /// String Value.
  /// </summary>
  public IStringVariantValue? StringVariantValue { get ; set; }
  
  /// <summary>
  /// Color Value.
  /// </summary>
  public IColorValue? ColorValue { get ; set; }
  
}
