namespace DocumentModel.Presentation;

/// <summary>
/// To.
/// </summary>
public interface IToVariantValue // : DocumentModel.Presentation.ITimeListAnimationVariantType
{
  public System.Boolean? BooleanVariantValue { get ; set; }
  
  public System.Int32? IntegerVariantValue { get ; set; }
  
  public System.Single? FloatVariantValue { get ; set; }
  
  public System.String? StringVariantValue { get ; set; }
  
  public DocumentModel.Presentation.IColorValue? ColorValue { get ; set; }
  
}
