namespace DocumentModel.Presentation;

public interface IToVariantValue // : DocumentFormat.OpenXml.Presentation.TimeListAnimationVariantType
{
  public IBooleanVariantValue? BooleanVariantValue { get ; set; }
  
  public IIntegerVariantValue? IntegerVariantValue { get ; set; }
  
  public IFloatVariantValue? FloatVariantValue { get ; set; }
  
  public IStringVariantValue? StringVariantValue { get ; set; }
  
  public IColorValue? ColorValue { get ; set; }
  
}
