namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TimeListAnimationVariantType Class.
/// </summary>
public interface TimeListAnimationVariantType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Boolean Variant.
  /// </summary>
  public Boolean? BooleanVariantValue { get ; set; }
  
  /// <summary>
  /// Integer.
  /// </summary>
  public Int32? IntegerVariantValue { get ; set; }
  
  /// <summary>
  /// Float Value.
  /// </summary>
  public Single? FloatVariantValue { get ; set; }
  
  /// <summary>
  /// String Value.
  /// </summary>
  public String? StringVariantValue { get ; set; }
  
  /// <summary>
  /// Color Value.
  /// </summary>
  public ColorValue? ColorValue { get ; set; }
  
}
