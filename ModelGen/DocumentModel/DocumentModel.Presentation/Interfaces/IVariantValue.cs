namespace DocumentModel.Presentation;

/// <summary>
/// Value.
/// </summary>
public interface IVariantValue // : DocumentModel.Presentation.ITimeListAnimationVariantType
{
  public Boolean? BooleanVariantValue { get ; set; }
  
  public Int32? IntegerVariantValue { get ; set; }
  
  public Single? FloatVariantValue { get ; set; }
  
  public String? StringVariantValue { get ; set; }
  
  public IColorValue? ColorValue { get ; set; }
  
}
