namespace DocumentModel.Presentation;

/// <summary>
/// To.
/// </summary>
public interface ToVariantValue // : DocumentModel.Presentation.TimeListAnimationVariantType
{
  public Boolean? BooleanVariantValue { get ; set; }
  
  public Int32? IntegerVariantValue { get ; set; }
  
  public Single? FloatVariantValue { get ; set; }
  
  public String? StringVariantValue { get ; set; }
  
  public ColorValue? ColorValue { get ; set; }
  
}
