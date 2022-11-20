namespace DocumentModel.Presentation;

/// <summary>
/// Value.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IColorValue))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBooleanVariantValue))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IFloatVariantValue))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IIntegerVariantValue))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IStringVariantValue))]
public interface IVariantValue // : DocumentFormat.OpenXml.Presentation.TimeListAnimationVariantType
{
  /// <summary>
  /// Boolean Variant.
  /// </summary>
  public IBooleanVariantValue? BooleanVariantValue { get ; set; }
  
  /// <summary>
  /// Integer.
  /// </summary>
  public IIntegerVariantValue? IntegerVariantValue { get ; set; }
  
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
