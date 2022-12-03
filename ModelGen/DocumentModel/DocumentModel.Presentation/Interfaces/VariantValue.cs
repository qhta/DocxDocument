namespace DocumentModel.Presentation;

/// <summary>
/// Value.
/// </summary>
public interface VariantValue // : DocumentModel.Presentation.TimeListAnimationVariantType
{
  public Boolean? BooleanVariantValue { get ; set; }
  
  public Int32? IntegerVariantValue { get ; set; }
  
  public Single? FloatVariantValue { get ; set; }
  
  public String? StringVariantValue { get ; set; }
  
  public ColorValue? ColorValue { get ; set; }
  
}
